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
    public class SubscriptionTests : SubscriptionsTestBase
    {

        private void ValidateSubscription(Subscription ua) {
            // Resource
            Assert.NotNull(ua);
            Assert.NotNull(ua.Id);
            Assert.NotNull(ua.Location);
            Assert.NotNull(ua.Name);
            Assert.NotNull(ua.Type);

            // Subscription
        }
        
        private void AssertSame(Subscription expected, Subscription given) {
            // Resource
            Assert.Equal(expected.Id, given.Id);
            Assert.Equal(expected.Location, given.Location);
            Assert.Equal(expected.Name, given.Name);
            Assert.Equal(expected.Type, given.Type);

            // Subscription
        }

        [Fact]
        public void TestListSubscriptions() {
            RunTest((client) => {
                var subscriptions = client.Subscriptions.List();
            });
        }

        [Fact]
        public void ListAdminOperations() {
            RunTest((client) => {
                client.ListOperations();
            });
        }
    }
}
