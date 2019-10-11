// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Deployment.Admin
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Deployment Admin Client
    /// </summary>
    public partial interface IDeploymentAdminClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Subscription credentials that uniquely identify Microsoft Azure
        /// subscription. The subscription ID forms part of the URI for every
        /// service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Client API Version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IActionPlansOperations.
        /// </summary>
        IActionPlansOperations ActionPlans { get; }

        /// <summary>
        /// Gets the IActionPlanOperations.
        /// </summary>
        IActionPlanOperations ActionPlanOperations { get; }

        /// <summary>
        /// Gets the IFileContainersOperations.
        /// </summary>
        IFileContainersOperations FileContainers { get; }

        /// <summary>
        /// Gets the IProductDeploymentsOperations.
        /// </summary>
        IProductDeploymentsOperations ProductDeployments { get; }

        /// <summary>
        /// Gets the IProductPackagesOperations.
        /// </summary>
        IProductPackagesOperations ProductPackages { get; }

        /// <summary>
        /// Gets the IProductSecretsOperations.
        /// </summary>
        IProductSecretsOperations ProductSecrets { get; }

    }
}
