// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.AzureBridge.Admin;
using Microsoft.AzureStack.Management.AzureBridge.Admin.Models;
using System;
using Xunit;

namespace AzureBridge.Tests
{
    public class DownloadedProductTests : AzureBridgeTestBase
    {
        [Fact]
        public void TestListDownloadedProducts() {
            RunTest((client) => {
                var list = client.DownloadedProducts.List("azurestack-activation", "default");
                Common.WriteIPagesToFile(list, client.DownloadedProducts.ListNext, "TestListDownloadedProducts");
            });
        }

        [Fact]
        public void TestGetNonExistantDownloadedProduct()
        {
            RunTest((client) => {
                var product = client.DownloadedProducts.Get("azurestack-activation", "default", "nonexsting -downloadedproduct");
                Assert.Null(product);
            });
        }
    }
}
