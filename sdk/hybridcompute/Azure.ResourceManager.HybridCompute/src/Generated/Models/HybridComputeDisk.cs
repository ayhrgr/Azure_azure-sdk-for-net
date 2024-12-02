// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes a disk on the machine. </summary>
    public partial class HybridComputeDisk
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HybridComputeDisk"/>. </summary>
        internal HybridComputeDisk()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HybridComputeDisk"/>. </summary>
        /// <param name="path"> The path of the disk. </param>
        /// <param name="diskType"> The type of the disk. </param>
        /// <param name="generatedId"> The generated ID of the disk. </param>
        /// <param name="id"> The ID of the disk. </param>
        /// <param name="name"> The name of the disk. </param>
        /// <param name="maxSizeInBytes"> The size of the disk, in bytes. </param>
        /// <param name="usedSpaceInBytes"> The amount of space used on the disk, in bytes. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HybridComputeDisk(string path, string diskType, string generatedId, ResourceIdentifier id, string name, long? maxSizeInBytes, long? usedSpaceInBytes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Path = path;
            DiskType = diskType;
            GeneratedId = generatedId;
            Id = id;
            Name = name;
            MaxSizeInBytes = maxSizeInBytes;
            UsedSpaceInBytes = usedSpaceInBytes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The path of the disk. </summary>
        [WirePath("path")]
        public string Path { get; }
        /// <summary> The type of the disk. </summary>
        [WirePath("diskType")]
        public string DiskType { get; }
        /// <summary> The generated ID of the disk. </summary>
        [WirePath("generatedId")]
        public string GeneratedId { get; }
        /// <summary> The ID of the disk. </summary>
        [WirePath("id")]
        public ResourceIdentifier Id { get; }
        /// <summary> The name of the disk. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> The size of the disk, in bytes. </summary>
        [WirePath("maxSizeInBytes")]
        public long? MaxSizeInBytes { get; }
        /// <summary> The amount of space used on the disk, in bytes. </summary>
        [WirePath("usedSpaceInBytes")]
        public long? UsedSpaceInBytes { get; }
    }
}
