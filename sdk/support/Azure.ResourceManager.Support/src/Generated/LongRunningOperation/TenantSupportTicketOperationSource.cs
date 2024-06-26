// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Support
{
    internal class TenantSupportTicketOperationSource : IOperationSource<TenantSupportTicketResource>
    {
        private readonly ArmClient _client;

        internal TenantSupportTicketOperationSource(ArmClient client)
        {
            _client = client;
        }

        TenantSupportTicketResource IOperationSource<TenantSupportTicketResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SupportTicketData.DeserializeSupportTicketData(document.RootElement);
            return new TenantSupportTicketResource(_client, data);
        }

        async ValueTask<TenantSupportTicketResource> IOperationSource<TenantSupportTicketResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SupportTicketData.DeserializeSupportTicketData(document.RootElement);
            return new TenantSupportTicketResource(_client, data);
        }
    }
}
