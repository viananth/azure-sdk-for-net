// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Gallery.Admin;
using Microsoft.AzureStack.Management.Gallery.Admin.Models;
using System;
using Xunit;
using System.Linq;

namespace Gallery.Tests
{
    public class OperationTests : GalleryTestBase
    {
        

        [Fact]
        public void TestGetOperations() {
            RunTest((client) => {
                var operations = client.Operations();
                Assert.NotNull(operations);
                Assert.Equal<int>(4,operations.Count());
            });
        }
    }
}
