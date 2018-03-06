// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//


namespace Network.Tests
{
    using Microsoft.AzureStack.Management.Network.Admin;
    using Microsoft.AzureStack.Management.Network.Admin.Models;
    using Xunit;

    public class LoadBalancers : NetworkTestBase
    {

        private void ValidateLoadBalancer(LoadBalancer loadBalancer)
        {
            NetworkCommon.ValidateBaseResources(loadBalancer);

            Assert.NotNull(loadBalancer.SubscriptionId);
            Assert.NotNull(loadBalancer.TenantResourceUri);
            Assert.NotNull(loadBalancer.PublicIpAddresses);
            foreach (string IpAddress in loadBalancer.PublicIpAddresses)
            {
                Assert.NotNull(IpAddress);
            }
        }
        private void AssertLoadBalancersAreSame(LoadBalancer expected, LoadBalancer found)
        {
            if (expected == null)
            {
                Assert.Null(found);
            }
            else
            {
                Assert.True(NetworkCommon.CheckBaseResourcesAreSame(expected, found));
                if (expected == null)
                {
                    Assert.Null(found);
                }
                else
                {
                    Assert.Equal(expected.ProvisioningState, found.ProvisioningState);
                    Assert.Equal(expected.SubscriptionId, found.SubscriptionId);
                    Assert.Equal(expected.TenantResourceUri, found.TenantResourceUri);
                }
                Assert.Equal(expected.PublicIpAddresses, found.PublicIpAddresses);
            }
        }

        [Fact]
        public void TestGetAllLoadBalancers()
        {
            RunTest((client) =>
            {
                var balancers = client.LoadBalancers.List();
                // This test should be using the SessionRecord which has an existing LoadBalancer created
                if (balancers != null)
                {
                    balancers.ForEach((loadBalancer) =>
                    {
                        ValidateLoadBalancer(loadBalancer);
                    });
                }
            });
        }
    }
}
