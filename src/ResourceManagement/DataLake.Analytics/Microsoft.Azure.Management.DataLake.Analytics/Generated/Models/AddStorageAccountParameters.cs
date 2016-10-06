// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Additional Azure Storage account parameters.
    /// </summary>
    public partial class AddStorageAccountParameters
    {
        /// <summary>
        /// Initializes a new instance of the AddStorageAccountParameters
        /// class.
        /// </summary>
        public AddStorageAccountParameters() { }

        /// <summary>
        /// Initializes a new instance of the AddStorageAccountParameters
        /// class.
        /// </summary>
        /// <param name="properties">the properties for the Azure Storage
        /// account being added.</param>
        public AddStorageAccountParameters(StorageAccountProperties properties)
        {
            Properties = properties;
        }

        /// <summary>
        /// Gets or sets the properties for the Azure Storage account being
        /// added.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public StorageAccountProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}