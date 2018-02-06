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
    public class RegistrationTests : GalleryTestBase
    {

        private void ValidateGalleryItem(GalleryItem item) {
            Assert.NotNull(item);

            // Gallery Item
            Assert.NotNull(item.AdditionalProperties);
            Assert.NotNull(item.Artifacts);
            Assert.NotNull(item.CategoryIds);
            Assert.NotNull(item.ChangedTime);
            Assert.NotNull(item.CreatedTime);
            Assert.NotNull(item.DefinitionTemplates);
            Assert.NotNull(item.Description);
            Assert.NotNull(item.Filters);
            Assert.NotNull(item.IconFileUris);
            Assert.NotNull(item.Identity);
            Assert.NotNull(item.Images);
            Assert.NotNull(item.ItemDisplayName);
            Assert.NotNull(item.ItemName);
            Assert.NotNull(item.ItemType);
            Assert.NotNull(item.Links);
            Assert.NotNull(item.LongSummary);
            Assert.NotNull(item.Metadata);
            Assert.NotNull(item.Products);
            Assert.NotNull(item.Properties);
            Assert.NotNull(item.Publisher);
            Assert.NotNull(item.PublisherDisplayName);
            Assert.NotNull(item.ScreenshotUris);
            Assert.NotNull(item.Summary);
            Assert.NotNull(item.UiDefinitionUri);
            Assert.NotNull(item.Version);
        }

        private void AssertAreSame(GalleryItem expected, GalleryItem given) {
            Assert.True(ResourcesSame(expected, given));
            if (expected != null)
            {
                if (expected.Artifacts == null)
                {
                    Assert.Null(given.Artifacts);
                }
                else
                {
                    Assert.Equal(expected.Artifacts.Count, given.Artifacts.Count);
                }

                Assert.Equal(expected.CategoryIds, given.CategoryIds);
                Assert.Equal(expected.Description, given.Description);
                Assert.Equal(expected.LongSummary, given.LongSummary);
                Assert.Equal(expected.Publisher, given.Publisher);
                Assert.Equal(expected.PublisherDisplayName, given.PublisherDisplayName);
                Assert.Equal(expected.UiDefinitionUri, given.UiDefinitionUri);
                Assert.Equal(expected.Version, given.Version);

            }
        }

        [Fact]
        public void TestListAllRegistrations() {
            RunTest((client) => {
                var registrations = client.Registrations.List();
                Assert.NotNull(registrations);
                registrations.WriteToFile("TestListAllRegistrations.txt", (item) => item.Identity);
                registrations.ForEach(ValidateGalleryItem);
            });
        }

        [Fact]
        public void TestGetRegistration() {
            RunTest((client) => {
                var registrations = client.Registrations.List();
                var first = registrations.First();
                var returned = client.Registrations.Get(first.Name);
                AssertAreSame(first, returned);
            });
        }

        [Fact]
        public void TestGetAllRegistrations() {
            RunTest((client) => {
                var registrations = client.Registrations.List();
                registrations.ForEach((given) => {
                    var returned = client.Registrations.Get(given.Name);
                    AssertAreSame(given, returned);
                });
            });
        }


        [Fact]
        public void TestCreateAndDeleteRegistration() {

            Action<GalleryAdminClient> beforeAfter = (client) => {
                var name = "microsoft.vmss.1.3.6";
                client.Registrations.Delete(name);
            };

            RunTest((client) => {
                var uri = "https://github.com/Azure/AzureStack-Tools/raw/master/ComputeAdmin/microsoft.vmss.1.3.6.azpkg";
                var registration = client.Registrations.Create(uri);
                Assert.NotNull(registration);
                client.Registrations.Delete(registration.Name);
            },
            before: beforeAfter,
            after: beforeAfter
            );
        }

    }
}
