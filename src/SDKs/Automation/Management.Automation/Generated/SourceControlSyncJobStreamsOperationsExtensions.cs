// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SourceControlSyncJobStreamsOperations.
    /// </summary>
    public static partial class SourceControlSyncJobStreamsOperationsExtensions
    {
            /// <summary>
            /// Retrieve a list of sync job streams identified by sync job id.
            /// <see href="http://aka.ms/azureautomationsdk/sourcecontrolsyncjoboperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='sourceControlName'>
            /// The source control name.
            /// </param>
            /// <param name='sourceControlSyncJobId'>
            /// The source control sync job id.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            public static IPage<SourceControlSyncJobStream> ListBySyncJob(this ISourceControlSyncJobStreamsOperations operations, string resourceGroupName, string automationAccountName, string sourceControlName, System.Guid sourceControlSyncJobId, string filter = default(string))
            {
                return operations.ListBySyncJobAsync(resourceGroupName, automationAccountName, sourceControlName, sourceControlSyncJobId, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of sync job streams identified by sync job id.
            /// <see href="http://aka.ms/azureautomationsdk/sourcecontrolsyncjoboperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='sourceControlName'>
            /// The source control name.
            /// </param>
            /// <param name='sourceControlSyncJobId'>
            /// The source control sync job id.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SourceControlSyncJobStream>> ListBySyncJobAsync(this ISourceControlSyncJobStreamsOperations operations, string resourceGroupName, string automationAccountName, string sourceControlName, System.Guid sourceControlSyncJobId, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySyncJobWithHttpMessagesAsync(resourceGroupName, automationAccountName, sourceControlName, sourceControlSyncJobId, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a sync job stream identified by stream id.
            /// <see href="http://aka.ms/azureautomationsdk/sourcecontrolsyncjoboperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='sourceControlName'>
            /// The source control name.
            /// </param>
            /// <param name='sourceControlSyncJobId'>
            /// The source control sync job id.
            /// </param>
            /// <param name='streamId'>
            /// The id of the sync job stream.
            /// </param>
            public static SourceControlSyncJobStreamById Get(this ISourceControlSyncJobStreamsOperations operations, string resourceGroupName, string automationAccountName, string sourceControlName, System.Guid sourceControlSyncJobId, string streamId)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName, sourceControlName, sourceControlSyncJobId, streamId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a sync job stream identified by stream id.
            /// <see href="http://aka.ms/azureautomationsdk/sourcecontrolsyncjoboperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='sourceControlName'>
            /// The source control name.
            /// </param>
            /// <param name='sourceControlSyncJobId'>
            /// The source control sync job id.
            /// </param>
            /// <param name='streamId'>
            /// The id of the sync job stream.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SourceControlSyncJobStreamById> GetAsync(this ISourceControlSyncJobStreamsOperations operations, string resourceGroupName, string automationAccountName, string sourceControlName, System.Guid sourceControlSyncJobId, string streamId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, sourceControlName, sourceControlSyncJobId, streamId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of sync job streams identified by sync job id.
            /// <see href="http://aka.ms/azureautomationsdk/sourcecontrolsyncjoboperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SourceControlSyncJobStream> ListBySyncJobNext(this ISourceControlSyncJobStreamsOperations operations, string nextPageLink)
            {
                return operations.ListBySyncJobNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of sync job streams identified by sync job id.
            /// <see href="http://aka.ms/azureautomationsdk/sourcecontrolsyncjoboperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SourceControlSyncJobStream>> ListBySyncJobNextAsync(this ISourceControlSyncJobStreamsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySyncJobNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}