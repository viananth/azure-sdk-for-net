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
using Microsoft.Azure;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Core
{
    /// <summary>
    /// Operations for managing data slices.
    /// </summary>
    public partial interface IDataSliceOperations
    {
        /// <summary>
        /// Gets the first page of data slice instances with the link to the
        /// next page.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='datasetName'>
        /// A unique dataset instance name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters specifying how to list data slices of the dataset.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List data slices operation response.
        /// </returns>
        Task<DataSliceListResponse> ListAsync(string resourceGroupName, string dataFactoryName, string datasetName, DataSliceListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the next page of data slice instances with the link to the
        /// next page.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next data slices page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List data slices operation response.
        /// </returns>
        Task<DataSliceListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Sets status of data slices over a time range for a specific dataset.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='datasetName'>
        /// A unique dataset instance name.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to set status of data slices.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> SetStatusAsync(string resourceGroupName, string dataFactoryName, string datasetName, DataSliceSetStatusParameters parameters, CancellationToken cancellationToken);
    }
}