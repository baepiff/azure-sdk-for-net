// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DependencyAction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DependencyAction
    {
        /// <summary>
        /// Satisfy tasks waiting on this task; once all dependencies are
        /// satisfied, the task will be scheduled to run.
        /// </summary>
        [EnumMember(Value = "satisfy")]
        Satisfy,
        /// <summary>
        /// Blocks tasks waiting on this task, preventing them from being
        /// scheduled.
        /// </summary>
        [EnumMember(Value = "block")]
        Block
    }
    internal static class DependencyActionEnumExtension
    {
        internal static string ToSerializedValue(this DependencyAction? value)
        {
            return value == null ? null : ((DependencyAction)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DependencyAction value)
        {
            switch( value )
            {
                case DependencyAction.Satisfy:
                    return "satisfy";
                case DependencyAction.Block:
                    return "block";
            }
            return null;
        }

        internal static DependencyAction? ParseDependencyAction(this string value)
        {
            switch( value )
            {
                case "satisfy":
                    return DependencyAction.Satisfy;
                case "block":
                    return DependencyAction.Block;
            }
            return null;
        }
    }
}
