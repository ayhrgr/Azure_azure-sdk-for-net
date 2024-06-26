// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ArtifactRenameRequestConverter))]
    public partial class ArtifactRenameRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NewName))
            {
                writer.WritePropertyName("newName"u8);
                writer.WriteStringValue(NewName);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue<ArtifactRenameRequest>(this);
            return content;
        }

        internal partial class ArtifactRenameRequestConverter : JsonConverter<ArtifactRenameRequest>
        {
            public override void Write(Utf8JsonWriter writer, ArtifactRenameRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<ArtifactRenameRequest>(model);
            }

            public override ArtifactRenameRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
        }
    }
}
