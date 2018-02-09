// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.AzureBridge.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Product resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ProductResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ProductResource class.
        /// </summary>
        public ProductResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProductResource class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location where resource is location.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="displayName">Name displayed for the product.</param>
        /// <param name="description">Description of the product.</param>
        /// <param name="publisherDisplayName">Name of publisher.</param>
        /// <param name="publisherIdentifier">Publisher identifier.</param>
        /// <param name="offer">Offer name.</param>
        /// <param name="offerVersion">Offer version.</param>
        /// <param name="sku">Product SKU.</param>
        /// <param name="billingPartNumber">Billing part number.</param>
        /// <param name="galleryItemIdentity">Gallery item identity.</param>
        /// <param name="iconUris">Information about gallery icons.</param>
        /// <param name="payloadLength">Size in bytes.</param>
        /// <param name="productKind">The kind. E.g.
        /// VirtualMachineProductProperties.ProductKind or WebApp,
        /// SolutionTemplate.</param>
        /// <param name="productProperties">the product properties. At the
        /// moment only VirtualMachineProductProperties is allowed.</param>
        /// <param name="vmExtensionType">Extension type of the VM.</param>
        /// <param name="links">Gallery item identity.</param>
        /// <param name="legalTerms">Legal terms for the product.</param>
        /// <param name="privacyPolicy">Privacy policy of the product.</param>
        public ProductResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string displayName = default(string), string description = default(string), string publisherDisplayName = default(string), string publisherIdentifier = default(string), string offer = default(string), string offerVersion = default(string), string sku = default(string), string billingPartNumber = default(string), string galleryItemIdentity = default(string), GalleryIcons iconUris = default(GalleryIcons), long? payloadLength = default(long?), string productKind = default(string), ProductProperties productProperties = default(ProductProperties), string vmExtensionType = default(string), IList<ProductLink> links = default(IList<ProductLink>), string legalTerms = default(string), string privacyPolicy = default(string))
            : base(id, name, type, location, tags)
        {
            DisplayName = displayName;
            Description = description;
            PublisherDisplayName = publisherDisplayName;
            PublisherIdentifier = publisherIdentifier;
            Offer = offer;
            OfferVersion = offerVersion;
            Sku = sku;
            BillingPartNumber = billingPartNumber;
            GalleryItemIdentity = galleryItemIdentity;
            IconUris = iconUris;
            PayloadLength = payloadLength;
            ProductKind = productKind;
            ProductProperties = productProperties;
            VmExtensionType = vmExtensionType;
            Links = links;
            LegalTerms = legalTerms;
            PrivacyPolicy = privacyPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name displayed for the product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets description of the product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets name of publisher.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisherDisplayName")]
        public string PublisherDisplayName { get; set; }

        /// <summary>
        /// Gets or sets publisher identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publisherIdentifier")]
        public string PublisherIdentifier { get; set; }

        /// <summary>
        /// Gets or sets offer name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.offer")]
        public string Offer { get; set; }

        /// <summary>
        /// Gets or sets offer version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.offerVersion")]
        public string OfferVersion { get; set; }

        /// <summary>
        /// Gets or sets product SKU.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Gets or sets billing part number.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingPartNumber")]
        public string BillingPartNumber { get; set; }

        /// <summary>
        /// Gets or sets gallery item identity.
        /// </summary>
        [JsonProperty(PropertyName = "properties.galleryItemIdentity")]
        public string GalleryItemIdentity { get; set; }

        /// <summary>
        /// Gets or sets information about gallery icons.
        /// </summary>
        [JsonProperty(PropertyName = "properties.iconUris")]
        public GalleryIcons IconUris { get; set; }

        /// <summary>
        /// Gets or sets size in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.payloadLength")]
        public long? PayloadLength { get; set; }

        /// <summary>
        /// Gets or sets the kind. E.g.
        /// VirtualMachineProductProperties.ProductKind or WebApp,
        /// SolutionTemplate.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productKind")]
        public string ProductKind { get; set; }

        /// <summary>
        /// Gets or sets the product properties. At the moment only
        /// VirtualMachineProductProperties is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productProperties")]
        public ProductProperties ProductProperties { get; set; }

        /// <summary>
        /// Gets or sets extension type of the VM.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vmExtensionType")]
        public string VmExtensionType { get; set; }

        /// <summary>
        /// Gets or sets gallery item identity.
        /// </summary>
        [JsonProperty(PropertyName = "properties.links")]
        public IList<ProductLink> Links { get; set; }

        /// <summary>
        /// Gets or sets legal terms for the product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.legalTerms")]
        public string LegalTerms { get; set; }

        /// <summary>
        /// Gets or sets privacy policy of the product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.privacyPolicy")]
        public string PrivacyPolicy { get; set; }

    }
}
