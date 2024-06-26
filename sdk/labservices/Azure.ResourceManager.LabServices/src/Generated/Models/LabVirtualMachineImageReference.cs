// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Image reference information. Used in the virtual machine profile. </summary>
    public partial class LabVirtualMachineImageReference
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

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineImageReference"/>. </summary>
        public LabVirtualMachineImageReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LabVirtualMachineImageReference"/>. </summary>
        /// <param name="id"> Image resource ID. </param>
        /// <param name="offer"> The image offer if applicable. </param>
        /// <param name="publisher"> The image publisher. </param>
        /// <param name="sku"> The image SKU. </param>
        /// <param name="version"> The image version specified on creation. </param>
        /// <param name="exactVersion"> The actual version of the image after use. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LabVirtualMachineImageReference(ResourceIdentifier id, string offer, string publisher, string sku, string version, string exactVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Offer = offer;
            Publisher = publisher;
            Sku = sku;
            Version = version;
            ExactVersion = exactVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Image resource ID. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> The image offer if applicable. </summary>
        public string Offer { get; set; }
        /// <summary> The image publisher. </summary>
        public string Publisher { get; set; }
        /// <summary> The image SKU. </summary>
        public string Sku { get; set; }
        /// <summary> The image version specified on creation. </summary>
        public string Version { get; set; }
        /// <summary> The actual version of the image after use. </summary>
        public string ExactVersion { get; }
    }
}
