// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//


namespace Network.Tests
{
    using Microsoft.AzureStack.Management.Network.Admin;
    using Microsoft.AzureStack.Management.Network.Admin.Models;
    using Xunit;

    public class PublicIPAddressesTests : NetworkTestBase
    {

        private void ValidatePublicIpAddress(PublicIpAddress ipAddress)
        {
            NetworkCommon.ValidateBaseResources(ipAddress);
            Assert.NotNull(ipAddress.SubscriptionId);
            Assert.NotNull(ipAddress.TenantResourceUri);
            Assert.Equal(ProvisioningState.Succeeded, ipAddress.ProvisioningState);
        }

        [Fact]
        public void TestGetAllPublicIpAddresses()
        {
            RunTest((client) =>
            {
                var addresses = client.PublicIPAddresses.List();
                Assert.NotNull(addresses);

                // This test should be using the SessionRecord which has an existing PublicIPAddress created
                if (addresses != null)
                {
                    addresses.ForEach((address) =>
                    {
                        ValidatePublicIpAddress(address);
                    });
                }
            });
        }
        [Fact]
        public void TestGetAllPublicIpAddressesOData()
        {
            RunTest((client) =>
            {
                Microsoft.Rest.Azure.OData.ODataQuery<PublicIpAddress> odataQuery = new Microsoft.Rest.Azure.OData.ODataQuery<PublicIpAddress>();
                odataQuery.Top = 10;

                var addresses = client.PublicIPAddresses.List(odataQuery);

                // This test should be using the SessionRecord which has an existing PublicIPAddress created
                if (addresses != null)
                {
                    addresses.ForEach((address) =>
                    {
                        ValidatePublicIpAddress(address);
                    });
                }
            });
        }
    }
}
