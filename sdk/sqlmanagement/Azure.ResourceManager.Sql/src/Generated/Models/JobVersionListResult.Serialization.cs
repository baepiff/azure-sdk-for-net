// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class JobVersionListResult
    {
        internal static JobVersionListResult DeserializeJobVersionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<JobVersion>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<JobVersion> array = new List<JobVersion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobVersion.DeserializeJobVersion(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new JobVersionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
