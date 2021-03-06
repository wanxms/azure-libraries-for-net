// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties describe the recommended machine configuration for this
    /// Image Definition. These properties are updatable.
    /// </summary>
    public partial class RecommendedMachineConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the RecommendedMachineConfiguration
        /// class.
        /// </summary>
        public RecommendedMachineConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecommendedMachineConfiguration
        /// class.
        /// </summary>
        public RecommendedMachineConfiguration(ResourceRange vCPUs = default(ResourceRange), ResourceRange memory = default(ResourceRange))
        {
            VCPUs = vCPUs;
            Memory = memory;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "vCPUs")]
        public ResourceRange VCPUs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public ResourceRange Memory { get; set; }

    }
}
