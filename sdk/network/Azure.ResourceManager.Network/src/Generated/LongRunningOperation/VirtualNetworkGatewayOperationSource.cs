// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class VirtualNetworkGatewayOperationSource : IOperationSource<VirtualNetworkGatewayResource>
    {
        private readonly ArmClient _client;

        internal VirtualNetworkGatewayOperationSource(ArmClient client)
        {
            _client = client;
        }

        VirtualNetworkGatewayResource IOperationSource<VirtualNetworkGatewayResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualNetworkGatewayData.DeserializeVirtualNetworkGatewayData(document.RootElement);
            return new VirtualNetworkGatewayResource(_client, data);
        }

        async ValueTask<VirtualNetworkGatewayResource> IOperationSource<VirtualNetworkGatewayResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualNetworkGatewayData.DeserializeVirtualNetworkGatewayData(document.RootElement);
            return new VirtualNetworkGatewayResource(_client, data);
        }
    }
}
