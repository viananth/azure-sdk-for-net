// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Subscriptions.Admin;
using Microsoft.AzureStack.Management.Subscriptions.Admin.Models;
using System.Linq;
using Xunit;

namespace Subscriptions.Tests
{
    public class DelegatedProviderTests : SubscriptionsTestBase
    {

        private void ValidateSubscription(Subscription item) {
            // Resource
            Assert.NotNull(item);
            Assert.NotNull(item.Id);
            Assert.NotNull(item.Location);
            Assert.NotNull(item.Name);
            Assert.NotNull(item.Type);

            // DelegatedProvider
        }

        private void AssertSame(Subscription expected, Subscription given) {
            // Resource
            Assert.Equal(expected.Id, given.Id);
            Assert.Equal(expected.Location, given.Location);
            Assert.Equal(expected.Name, given.Name);
            Assert.Equal(expected.Type, given.Type);

            // DelegatedProvider
            Assert.Equal(expected.DelegatedProviderSubscriptionId, given.DelegatedProviderSubscriptionId);
            Assert.Equal(expected.DisplayName, given.DisplayName);
            Assert.Equal(expected.ExternalReferenceId, given.ExternalReferenceId);
            Assert.Equal(expected.OfferId, given.OfferId);
            Assert.Equal(expected.Owner, given.Owner);
            Assert.Equal(expected.RoutingResourceManagerType, given.RoutingResourceManagerType);
            Assert.Equal(expected.State, given.State);
            Assert.Equal(expected.SubscriptionId, given.SubscriptionId);
            Assert.Equal(expected.TenantId, given.TenantId);
        }

        [Fact]
        public void TestListDelegatedProviders() {
            RunTest((client) => {
                var delegatedProviders = client.DelegatedProviders.List();
                delegatedProviders.ForEach(ValidateSubscription);
            });
        }

        [Fact]
        public void TestGetAllDelegatedProviders() {
            RunTest((client) => {
                var delegatedProviders = client.DelegatedProviders.List();
                delegatedProviders.ForEach((provider) => {
                    var result = client.DelegatedProviders.Get(provider.Name);
                    AssertSame(provider, result);
                });
            });
        }

        [Fact]
        public void TestGetDelegatedProvider() {
            RunTest((client) => {
                var provider = client.DelegatedProviders.List().First();
                var result = client.DelegatedProviders.Get(provider.Name);
                AssertSame(provider, result);
            });
        }
    }
}
