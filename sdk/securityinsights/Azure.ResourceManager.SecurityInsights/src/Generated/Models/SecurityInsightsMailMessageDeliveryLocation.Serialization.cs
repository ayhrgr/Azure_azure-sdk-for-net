// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal static partial class SecurityInsightsMailMessageDeliveryLocationExtensions
    {
        public static string ToSerialString(this SecurityInsightsMailMessageDeliveryLocation value) => value switch
        {
            SecurityInsightsMailMessageDeliveryLocation.Unknown => "Unknown",
            SecurityInsightsMailMessageDeliveryLocation.Inbox => "Inbox",
            SecurityInsightsMailMessageDeliveryLocation.JunkFolder => "JunkFolder",
            SecurityInsightsMailMessageDeliveryLocation.DeletedFolder => "DeletedFolder",
            SecurityInsightsMailMessageDeliveryLocation.Quarantine => "Quarantine",
            SecurityInsightsMailMessageDeliveryLocation.External => "External",
            SecurityInsightsMailMessageDeliveryLocation.Failed => "Failed",
            SecurityInsightsMailMessageDeliveryLocation.Dropped => "Dropped",
            SecurityInsightsMailMessageDeliveryLocation.Forwarded => "Forwarded",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SecurityInsightsMailMessageDeliveryLocation value.")
        };

        public static SecurityInsightsMailMessageDeliveryLocation ToSecurityInsightsMailMessageDeliveryLocation(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Unknown")) return SecurityInsightsMailMessageDeliveryLocation.Unknown;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Inbox")) return SecurityInsightsMailMessageDeliveryLocation.Inbox;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "JunkFolder")) return SecurityInsightsMailMessageDeliveryLocation.JunkFolder;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "DeletedFolder")) return SecurityInsightsMailMessageDeliveryLocation.DeletedFolder;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Quarantine")) return SecurityInsightsMailMessageDeliveryLocation.Quarantine;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "External")) return SecurityInsightsMailMessageDeliveryLocation.External;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Failed")) return SecurityInsightsMailMessageDeliveryLocation.Failed;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Dropped")) return SecurityInsightsMailMessageDeliveryLocation.Dropped;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Forwarded")) return SecurityInsightsMailMessageDeliveryLocation.Forwarded;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SecurityInsightsMailMessageDeliveryLocation value.");
        }
    }
}
