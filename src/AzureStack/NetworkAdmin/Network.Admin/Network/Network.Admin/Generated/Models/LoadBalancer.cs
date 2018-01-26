// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Network.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Representation of a load balancer.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LoadBalancer : ResourceTenant
    {
        /// <summary>
        /// Initializes a new instance of the LoadBalancer class.
        /// </summary>
        public LoadBalancer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoadBalancer class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Region Location of resource.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="provisioningState">The provisioning state.</param>
        /// <param name="subscriptionId">The subscription Id.</param>
        /// <param name="tenantResourceUri">The tenant resource URI.</param>
        /// <param name="publicIpAddresses">List of public IP
        /// addresses.</param>
        public LoadBalancer(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string provisioningState = default(string), string subscriptionId = default(string), string tenantResourceUri = default(string), IList<string> publicIpAddresses = default(IList<string>))
            : base(id, name, type, location, tags, provisioningState, subscriptionId, tenantResourceUri)
        {
            PublicIpAddresses = publicIpAddresses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of public IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIpAddresses")]
        public IList<string> PublicIpAddresses { get; set; }

    }
}
