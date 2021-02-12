// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class CloudErrorAutoGenerated
    {
        internal static CloudErrorAutoGenerated DeserializeCloudErrorAutoGenerated(JsonElement element)
        {
            string code = default;
            string message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<CloudErrorAutoGenerated>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("code"))
                        {
                            code = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("message"))
                        {
                            message = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("target"))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("details"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<CloudErrorAutoGenerated> array = new List<CloudErrorAutoGenerated>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeCloudErrorAutoGenerated(item));
                            }
                            details = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CloudErrorAutoGenerated(code, message, target.Value, Optional.ToList(details));
        }
    }
}
