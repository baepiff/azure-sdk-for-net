// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DigitalTwins.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// properties related to servicebus.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ServiceBus")]
    public partial class ServiceBus : DigitalTwinsEndpointResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the ServiceBus class.
        /// </summary>
        public ServiceBus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceBus class.
        /// </summary>
        /// <param name="primaryConnectionString">PrimaryConnectionString of
        /// the endpoint. Will be obfuscated during read</param>
        /// <param name="secondaryConnectionString">SecondaryConnectionString
        /// of the endpoint. Will be obfuscated during read</param>
        /// <param name="provisioningState">The provisioning state. Possible
        /// values include: 'Provisioning', 'Deleting', 'Succeeded', 'Failed',
        /// 'Canceled'</param>
        /// <param name="createdTime">Time when the Endpoint was added to
        /// DigitalTwinsInstance.</param>
        /// <param name="tags">The resource tags.</param>
        public ServiceBus(string primaryConnectionString, string secondaryConnectionString, string provisioningState = default(string), System.DateTime? createdTime = default(System.DateTime?), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(provisioningState, createdTime, tags)
        {
            PrimaryConnectionString = primaryConnectionString;
            SecondaryConnectionString = secondaryConnectionString;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets primaryConnectionString of the endpoint. Will be
        /// obfuscated during read
        /// </summary>
        [JsonProperty(PropertyName = "primaryConnectionString")]
        public string PrimaryConnectionString { get; set; }

        /// <summary>
        /// Gets or sets secondaryConnectionString of the endpoint. Will be
        /// obfuscated during read
        /// </summary>
        [JsonProperty(PropertyName = "secondaryConnectionString")]
        public string SecondaryConnectionString { get; set; }

    }
}