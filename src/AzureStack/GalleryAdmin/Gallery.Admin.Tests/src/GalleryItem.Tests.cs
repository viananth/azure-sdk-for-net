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
        public void TestListGalleryItems() {
            RunTest((client) => {
                var galleryItems = client.GalleryItems.List();
                Assert.NotNull(galleryItems);
            });
        }

        [Fact]
        public void TestGetGalleryItem()
        {
            RunTest((client) => {
                var galleryItem = client.GalleryItems.Get("Microsoft.KeyVault.1.0.14");
                Assert.NotNull(galleryItem);
            });
        }
    }
}
