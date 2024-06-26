// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The policy details. </summary>
    public partial class PolicyDetails
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

        /// <summary> Initializes a new instance of <see cref="PolicyDetails"/>. </summary>
        internal PolicyDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicyDetails"/>. </summary>
        /// <param name="policyDefinitionId"> The ID of the policy definition. </param>
        /// <param name="policyAssignmentId"> The ID of the policy assignment. </param>
        /// <param name="policyAssignmentDisplayName"> The display name of the policy assignment. </param>
        /// <param name="policyAssignmentScope"> The scope of the policy assignment. </param>
        /// <param name="policySetDefinitionId"> The ID of the policy set definition. </param>
        /// <param name="policyDefinitionReferenceId"> The policy definition reference ID within the policy set definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PolicyDetails(ResourceIdentifier policyDefinitionId, ResourceIdentifier policyAssignmentId, string policyAssignmentDisplayName, string policyAssignmentScope, ResourceIdentifier policySetDefinitionId, string policyDefinitionReferenceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PolicyDefinitionId = policyDefinitionId;
            PolicyAssignmentId = policyAssignmentId;
            PolicyAssignmentDisplayName = policyAssignmentDisplayName;
            PolicyAssignmentScope = policyAssignmentScope;
            PolicySetDefinitionId = policySetDefinitionId;
            PolicyDefinitionReferenceId = policyDefinitionReferenceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of the policy definition. </summary>
        public ResourceIdentifier PolicyDefinitionId { get; }
        /// <summary> The ID of the policy assignment. </summary>
        public ResourceIdentifier PolicyAssignmentId { get; }
        /// <summary> The display name of the policy assignment. </summary>
        public string PolicyAssignmentDisplayName { get; }
        /// <summary> The scope of the policy assignment. </summary>
        public string PolicyAssignmentScope { get; }
        /// <summary> The ID of the policy set definition. </summary>
        public ResourceIdentifier PolicySetDefinitionId { get; }
        /// <summary> The policy definition reference ID within the policy set definition. </summary>
        public string PolicyDefinitionReferenceId { get; }
    }
}
