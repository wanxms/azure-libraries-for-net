// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machines scale set IP Configuration's
    /// PublicIPAddress configuration
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineScaleSetPublicIPAddressConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetPublicIPAddressConfiguration class.
        /// </summary>
        public VirtualMachineScaleSetPublicIPAddressConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetPublicIPAddressConfiguration class.
        /// </summary>
        /// <param name="name">The publicIP address configuration name.</param>
        /// <param name="idleTimeoutInMinutes">The idle timeout of the public
        /// IP address.</param>
        /// <param name="dnsSettings">The dns settings to be applied on the
        /// publicIP addresses .</param>
        /// <param name="ipTags">The list of IP tags associated with the public
        /// IP address.</param>
        /// <param name="publicIPPrefix">The PublicIPPrefix from which to
        /// allocate publicIP addresses.</param>
        public VirtualMachineScaleSetPublicIPAddressConfiguration(string name, int? idleTimeoutInMinutes = default(int?), VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings dnsSettings = default(VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings), IList<VirtualMachineScaleSetIpTag> ipTags = default(IList<VirtualMachineScaleSetIpTag>), Management.ResourceManager.Fluent.SubResource publicIPPrefix = default(Management.ResourceManager.Fluent.SubResource))
        {
            Name = name;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            DnsSettings = dnsSettings;
            IpTags = ipTags;
            PublicIPPrefix = publicIPPrefix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the publicIP address configuration name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the idle timeout of the public IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the dns settings to be applied on the publicIP
        /// addresses .
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSettings")]
        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DnsSettings { get; set; }

        /// <summary>
        /// Gets or sets the list of IP tags associated with the public IP
        /// address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipTags")]
        public IList<VirtualMachineScaleSetIpTag> IpTags { get; set; }

        /// <summary>
        /// Gets or sets the PublicIPPrefix from which to allocate publicIP
        /// addresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPPrefix")]
        public Management.ResourceManager.Fluent.SubResource PublicIPPrefix { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (DnsSettings != null)
            {
                DnsSettings.Validate();
            }
        }
    }
}
