// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Resources.Models;

namespace Microsoft.Azure.Management.Resources
{
    public static partial class ProviderOperationsMetadataOperationsExtensions
    {
        /// <summary>
        /// Gets provider operations metadata
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperationsMetadataOperations.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Namespace of the resource provider.
        /// </param>
        /// <returns>
        /// Provider operations metadata
        /// </returns>
        public static ProviderOperationsMetadataGetResult Get(this IProviderOperationsMetadataOperations operations, string resourceProviderNamespace)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProviderOperationsMetadataOperations)s).GetAsync(resourceProviderNamespace);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets provider operations metadata
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperationsMetadataOperations.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// Required. Namespace of the resource provider.
        /// </param>
        /// <returns>
        /// Provider operations metadata
        /// </returns>
        public static Task<ProviderOperationsMetadataGetResult> GetAsync(this IProviderOperationsMetadataOperations operations, string resourceProviderNamespace)
        {
            return operations.GetAsync(resourceProviderNamespace, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets provider operations metadata list
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperationsMetadataOperations.
        /// </param>
        /// <returns>
        /// Provider operations metadata list
        /// </returns>
        public static ProviderOperationsMetadataListResult List(this IProviderOperationsMetadataOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProviderOperationsMetadataOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets provider operations metadata list
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Resources.IProviderOperationsMetadataOperations.
        /// </param>
        /// <returns>
        /// Provider operations metadata list
        /// </returns>
        public static Task<ProviderOperationsMetadataListResult> ListAsync(this IProviderOperationsMetadataOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}
