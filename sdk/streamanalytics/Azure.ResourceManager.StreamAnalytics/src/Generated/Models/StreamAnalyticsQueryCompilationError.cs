// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> An error produced by the compiler. </summary>
    public partial class StreamAnalyticsQueryCompilationError
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

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsQueryCompilationError"/>. </summary>
        internal StreamAnalyticsQueryCompilationError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsQueryCompilationError"/>. </summary>
        /// <param name="message"> The content of the error message. </param>
        /// <param name="startLine"> Describes the error location in the original query. Not set if isGlobal is true. </param>
        /// <param name="startColumn"> Describes the error location in the original query. Not set if isGlobal is true. </param>
        /// <param name="endLine"> Describes the error location in the original query. Not set if isGlobal is true. </param>
        /// <param name="endColumn"> Describes the error location in the original query. Not set if isGlobal is true. </param>
        /// <param name="isGlobal"> Whether the error is not for a specific part but for the entire query. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsQueryCompilationError(string message, int? startLine, int? startColumn, int? endLine, int? endColumn, bool? isGlobal, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Message = message;
            StartLine = startLine;
            StartColumn = startColumn;
            EndLine = endLine;
            EndColumn = endColumn;
            IsGlobal = isGlobal;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The content of the error message. </summary>
        public string Message { get; }
        /// <summary> Describes the error location in the original query. Not set if isGlobal is true. </summary>
        public int? StartLine { get; }
        /// <summary> Describes the error location in the original query. Not set if isGlobal is true. </summary>
        public int? StartColumn { get; }
        /// <summary> Describes the error location in the original query. Not set if isGlobal is true. </summary>
        public int? EndLine { get; }
        /// <summary> Describes the error location in the original query. Not set if isGlobal is true. </summary>
        public int? EndColumn { get; }
        /// <summary> Whether the error is not for a specific part but for the entire query. </summary>
        public bool? IsGlobal { get; }
    }
}
