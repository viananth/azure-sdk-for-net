﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.Subscriptions.Admin;
using Microsoft.AzureStack.Management.Subscriptions.Admin.Models;
using System;
using Xunit;

namespace Subscriptions.Tests
{
    public class DelegatedProviderOfferTests : SubscriptionsTestBase
    {

        private void ValidateUsageAggregate(DelegatedProviderOffer ua) {
            // Resource
            Assert.NotNull(ua);
            Assert.NotNull(ua.Id);
            Assert.NotNull(ua.Location);
            Assert.NotNull(ua.Name);
            Assert.NotNull(ua.Type);

            // DelegatedProviderOffer
        }

        private void AssertSame(DelegatedProviderOffer expected, DelegatedProviderOffer given) {
            // Resource
            Assert.Equal(expected.Id, given.Id);
            Assert.Equal(expected.Location, given.Location);
            Assert.Equal(expected.Name, given.Name);
            Assert.Equal(expected.Type, given.Type);

            // DelegatedProviderOffer

        }
        [Fact]
        public void TestListDelegatedProviderOffers() {
            RunTest((client) => {
                var providers = client.DelegatedProviders.List();
                providers.ForEach((provider) => {
                    var resourceGroup = Common.GetResourceGroupFromId(provider.Id);
                    client.DelegatedProviderOffers.List(provider.DelegatedProviderSubscriptionId);
                });
            });
        }
    }
}
