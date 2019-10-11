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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ActionPlanOperations.
    /// </summary>
    public static partial class ActionPlanOperationsExtensions
    {
            /// <summary>
            /// Lists the action plan operations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='planId'>
            /// Identifier of the action plan.
            /// </param>
            public static IPage<ActionPlanOperationResourceEntity> List(this IActionPlanOperations operations, string planId)
            {
                return operations.ListAsync(planId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the action plan operations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='planId'>
            /// Identifier of the action plan.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ActionPlanOperationResourceEntity>> ListAsync(this IActionPlanOperations operations, string planId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(planId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified action plan operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='planId'>
            /// Identifier of the action plan.
            /// </param>
            /// <param name='operationId'>
            /// Identifier of the action plan operation.
            /// </param>
            public static ActionPlanOperationResourceEntity Get(this IActionPlanOperations operations, string planId, string operationId)
            {
                return operations.GetAsync(planId, operationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified action plan operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='planId'>
            /// Identifier of the action plan.
            /// </param>
            /// <param name='operationId'>
            /// Identifier of the action plan operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActionPlanOperationResourceEntity> GetAsync(this IActionPlanOperations operations, string planId, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(planId, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the action plan operations
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ActionPlanOperationResourceEntity> ListNext(this IActionPlanOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the action plan operations
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
            public static async Task<IPage<ActionPlanOperationResourceEntity>> ListNextAsync(this IActionPlanOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
