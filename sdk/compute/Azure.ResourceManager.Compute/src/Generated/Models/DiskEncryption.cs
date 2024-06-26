// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Encryption at rest settings for disk or snapshot. </summary>
    public partial class DiskEncryption
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

        /// <summary> Initializes a new instance of <see cref="DiskEncryption"/>. </summary>
        public DiskEncryption()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DiskEncryption"/>. </summary>
        /// <param name="diskEncryptionSetId"> ResourceId of the disk encryption set to use for enabling encryption at rest. </param>
        /// <param name="encryptionType"> The type of key used to encrypt the data of the disk. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskEncryption(ResourceIdentifier diskEncryptionSetId, ComputeEncryptionType? encryptionType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskEncryptionSetId = diskEncryptionSetId;
            EncryptionType = encryptionType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ResourceId of the disk encryption set to use for enabling encryption at rest. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; set; }
        /// <summary> The type of key used to encrypt the data of the disk. </summary>
        public ComputeEncryptionType? EncryptionType { get; set; }
    }
}
