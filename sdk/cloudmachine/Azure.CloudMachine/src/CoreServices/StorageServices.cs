﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Threading.Tasks;
using Azure.Messaging.EventGrid;
using Azure.Messaging.EventGrid.SystemEvents;
using Azure.Core;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
using Azure.Messaging.ServiceBus;

namespace Azure.CloudMachine;

/// <summary>
/// The storage services for the cloud machine.
/// </summary>
public readonly struct StorageServices
{
    private readonly CloudMachineClient _cm;

    internal StorageServices(CloudMachineClient cm) => _cm = cm;

    private BlobContainerClient GetDefaultContainer()
    {
        CloudMachineClient cm = _cm;
        BlobContainerClient container = _cm.Subclients.Get(() =>
        {
            ClientConnectionOptions connection = cm.GetConnectionOptions(typeof(BlobContainerClient), default);
            BlobContainerClient container = new(connection.Endpoint, connection.TokenCredential);
            return container;
        });
        return container;
    }

    private BlobContainerClient GetContainer(string containerName)
    {
        string blobContainerClientId = typeof(BlobContainerClient).FullName;
        CloudMachineClient cm = _cm;
        BlobContainerClient container = cm.Subclients.Get(() =>
        {
            ClientConnectionOptions connection = cm.GetConnectionOptions(typeof(BlobContainerClient), containerName);
            BlobContainerClient container = new(connection.Endpoint, connection.TokenCredential);
            return container;
        });
        return container;
    }

    /// <summary>
    /// Uploads a JSON object to the storage account.
    /// </summary>
    /// <param name="json"></param>
    /// <param name="name"></param>
    /// <param name="overwrite"></param>
    /// <returns></returns>
    public string UploadJson(object json, string name = default, bool overwrite = false)
    {
        BlobContainerClient container = GetDefaultContainer();

        if (name == default)
            name = $"b{Guid.NewGuid()}";

        var client = container.GetBlockBlobClient(name);
        var options = new BlobUploadOptions
        {
            Conditions = overwrite ? null : new BlobRequestConditions { IfNoneMatch = new ETag("*") },
            HttpHeaders = new BlobHttpHeaders { ContentType = ContentType.ApplicationJson.ToString() }
        };

        client.Upload(BinaryData.FromObjectAsJson(json).ToStream(), options);
        return name;
    }

    /// <summary>
    /// Uploads a file to the storage account.
    /// </summary>
    /// <param name="fileStream"></param>
    /// <param name="name"></param>
    /// <param name="overwrite"></param>
    /// <returns></returns>
    public string UploadStream(Stream fileStream, string name = default, bool overwrite = false)
    {
        BlobContainerClient container = GetDefaultContainer();

        if (name == default)
            name = $"b{Guid.NewGuid()}";

        var client = container.GetBlockBlobClient(name);
        var options = new BlobUploadOptions
        {
            Conditions = overwrite ? null : new BlobRequestConditions { IfNoneMatch = new ETag("*") },
            HttpHeaders = new BlobHttpHeaders { ContentType = ContentType.ApplicationOctetStream.ToString() }
        };

        client.Upload(fileStream, options);
        return name;
    }

    /// <summary>
    /// Uploads a binary data object to the storage account.
    /// </summary>
    /// <param name="data"></param>
    /// <param name="name"></param>
    /// <param name="overwrite"></param>
    /// <returns></returns>
    public string UploadBinaryData(BinaryData data, string name = default, bool overwrite = false)
    {
        BlobContainerClient container = GetDefaultContainer();
        if (name == default)
            name = $"b{Guid.NewGuid()}";

        var client = container.GetBlockBlobClient(name);
        var options = new BlobUploadOptions
        {
            Conditions = overwrite ? null : new BlobRequestConditions { IfNoneMatch = new ETag("*") },
            HttpHeaders = new BlobHttpHeaders { ContentType = ContentType.ApplicationOctetStream.ToString() }
        };

        client.Upload(data.ToStream(), options);
        return name;
    }

    /// <summary>
    /// Uploads a byte array to the storage account.
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="name"></param>
    /// <param name="overwrite"></param>
    /// <returns></returns>
    public string UploadBytes(byte[] bytes, string name = default, bool overwrite = false)
        => UploadBinaryData(BinaryData.FromBytes(bytes), name, overwrite);

    /// <summary>
    /// Uploads a byte array to the storage account.
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="name"></param>
    /// <param name="overwrite"></param>
    /// <returns></returns>
    public string UploadBytes(ReadOnlyMemory<byte> bytes, string name = default, bool overwrite = false)
        => UploadBinaryData(BinaryData.FromBytes(bytes), name, overwrite);

    /// <summary>
    /// Uploads a file to the storage account.
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public BinaryData DownloadBlob(string path)
    {
        BlobClient blob = GetBlobClientFromPath(path, null);
        BlobDownloadResult result = blob.DownloadContent();
        return result.Content;
    }

    /// <summary>
    /// Deletes a blob from the storage account.
    /// </summary>
    /// <param name="path"></param>
    public void DeleteBlob(string path)
    {
        BlobClient blob = GetBlobClientFromPath(path, null);
        blob.DeleteIfExists();
    }

    private BlobClient GetBlobClientFromPath(string path, string containerName)
    {
        var _blobContainer = GetDefaultContainer();
        var blobPath = ConvertPathToBlobPath(path, _blobContainer);
        if (containerName is null)
        {
            return _blobContainer.GetBlobClient(blobPath);
        }
        else
        {
            var container = GetContainer(containerName);
            container.CreateIfNotExists();
            return container.GetBlobClient(blobPath);
        }
    }

    private static string ConvertPathToBlobPath(string path, BlobContainerClient container)
    {
        if (Uri.TryCreate(path, UriKind.Absolute, out Uri blobUri))
        {
            if (blobUri.Host == container.Uri.Host)
                return blobUri.AbsoluteUri.Substring(container.Uri.AbsoluteUri.Length);
            if (!string.IsNullOrEmpty(blobUri.LocalPath))
            {
                return blobUri.LocalPath.Substring(Path.GetPathRoot(path).Length).Replace('\\', '/');
            }
        }
        return path.Substring(Path.GetPathRoot(path).Length).Replace('\\', '/');
    }

    /// <summary>
    /// Adds a function to be called when a blob is uploaded.
    /// </summary>
    /// <param name="function"></param>
    public void WhenBlobUploaded(Action<StorageFile> function)
    {
        CloudMachineClient cm = _cm;
        // TODO (Pri 0): once the cache gets GCed, we will stop receiving events
        ServiceBusProcessor processor = cm.Messaging.GetServiceBusProcessor("$private");
        // TODO: How to unsubscribe?
        processor.ProcessMessageAsync += async (args) =>
        {
            EventGridEvent e = EventGridEvent.Parse(args.Message.Body);
            if (e.TryGetSystemEventData(out object systemEvent))
            {
                switch (systemEvent)
                {
                    case StorageBlobCreatedEventData bc:
                        var blobUri = bc.Url;
                        var requestId = bc.ClientRequestId;
                        // _logger.Log.EventReceived(nameof(OnProcessMessage), $"StorageBlobCreatedEventData: blobUri='{blobUri}' requestId='{requestId}'");

                        var eventArgs = new StorageFile(cm.Storage, blobUri, requestId, default);
                        function(eventArgs);
                        await args.CompleteMessageAsync(args.Message).ConfigureAwait(false);
                        break;
                    default:
                        break;
                }
            }
            await Task.CompletedTask.ConfigureAwait(false);
        };
#pragma warning disable AZC0102 // Do not use GetAwaiter().GetResult().
        processor.StartProcessingAsync().GetAwaiter().GetResult();
#pragma warning restore AZC0102 // Do not use GetAwaiter().GetResult().

    }
}
