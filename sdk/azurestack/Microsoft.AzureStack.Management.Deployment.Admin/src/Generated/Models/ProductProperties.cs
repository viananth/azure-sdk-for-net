// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Deployment.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional properties of the product
    /// </summary>
    public partial class ProductProperties
    {
        /// <summary>
        /// Initializes a new instance of the ProductProperties class.
        /// </summary>
        public ProductProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProductProperties class.
        /// </summary>
        /// <param name="version">The version of the product</param>
        public ProductProperties(string version = default(string))
        {
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version of the product
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
