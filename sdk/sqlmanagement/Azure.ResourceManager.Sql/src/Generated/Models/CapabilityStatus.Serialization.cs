// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class CapabilityStatusExtensions
    {
        public static string ToSerialString(this CapabilityStatus value) => value switch
        {
            CapabilityStatus.Visible => "Visible",
            CapabilityStatus.Available => "Available",
            CapabilityStatus.Default => "Default",
            CapabilityStatus.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CapabilityStatus value.")
        };

        public static CapabilityStatus ToCapabilityStatus(this string value)
        {
            if (string.Equals(value, "Visible", StringComparison.InvariantCultureIgnoreCase)) return CapabilityStatus.Visible;
            if (string.Equals(value, "Available", StringComparison.InvariantCultureIgnoreCase)) return CapabilityStatus.Available;
            if (string.Equals(value, "Default", StringComparison.InvariantCultureIgnoreCase)) return CapabilityStatus.Default;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return CapabilityStatus.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CapabilityStatus value.");
        }
    }
}
