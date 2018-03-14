// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Subscriptions.Admin;
using Microsoft.AzureStack.Management.Subscriptions.Admin.Models;
using System;
using Xunit;

namespace Subscriptions.Tests
{
    public class DirectoryTenantTests : SubscriptionsTestBase
    {

        private void ValidateDirectoryTenant(DirectoryTenant item) {
            // Resource
            Assert.NotNull(item);
            Assert.NotNull(item.Id);
            Assert.NotNull(item.Location);
            Assert.NotNull(item.Name);
            Assert.NotNull(item.Type);

            // DirectoryTenant
            Assert.NotNull(item.TenantId);
        }

        private void AssertSame(DirectoryTenant expected, DirectoryTenant given) {
            // Resource
            Assert.Equal(expected.Id, given.Id);
            Assert.Equal(expected.Location, given.Location);
            Assert.Equal(expected.Name, given.Name);
            Assert.Equal(expected.Type, given.Type);

            // DirectoryTenant
            Assert.Equal(expected.TenantId, given.TenantId);
        }

        [Fact]
        public void TestListDirectoryTenants() {
            RunTest((client) => {
                var directoryTenants = client.DirectoryTenants.List("System.local");
                directoryTenants.ForEach(client.DirectoryTenants.ListNext, ValidateDirectoryTenant);
            });
        }

        [Fact]
        public void TestGetAllDirectoryTenants() {
            RunTest((client) => {
                var directoryTenants = client.DirectoryTenants.List("System.local");
                directoryTenants.ForEach(client.DirectoryTenants.ListNext, (tenant) => {
                    var result = client.DirectoryTenants.Get("System.local", tenant.Name);
                    AssertSame(tenant, result);
                });
            });
        }

        [Fact]
        public void TestGetDirectoryTenant() {
            RunTest((client) => {
                var tenant = client.DirectoryTenants.List("System.local").GetFirst();
                var result = client.DirectoryTenants.Get("System.local", tenant.Name);
                AssertSame(tenant, result);
            });
        }

        public void TestCreateUpdateThenDeleteDirectoryTenant() {
            RunTest((client) => {
                var directoryTenantName = "azurestackci05.onmicrosoft.in";

                var tenantDir = new DirectoryTenant(location: "local")
                {
                    TenantId = Guid.NewGuid().ToString()
                };
                tenantDir.TenantId = Guid.NewGuid().ToString();
                var result = client.DirectoryTenants.CreateOrUpdate("System.local", directoryTenantName, tenantDir);

                var createdTenant = client.DirectoryTenants.Get("System.Local", directoryTenantName);
                Assert.Equal(tenantDir.TenantId, result.TenantId);
                Assert.Equal(tenantDir.TenantId, createdTenant.TenantId);

                client.DirectoryTenants.Delete("System.Local", tenantDir.TenantId);

                //Product BUG, the following fails
                //var deletedTenant = client.DirectoryTenants.Get("System.Local", directoryTenantName);
                //Assert.Null(deletedTenant);
            });
        }
    }
}
