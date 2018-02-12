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
    public class PlanTests : SubscriptionsTestBase
    {

        private void ValidateUsageAggregate(Plan ua) {
            // Resource
            Assert.NotNull(ua);
            Assert.NotNull(ua.Id);
            Assert.NotNull(ua.Location);
            Assert.NotNull(ua.Name);
            Assert.NotNull(ua.Type);

            // Plan
        }

        private void AssertSame(Plan expected, Plan given) {
            // Resource
            Assert.Equal(expected.Id, given.Id);
            Assert.Equal(expected.Location, given.Location);
            Assert.Equal(expected.Name, given.Name);
            Assert.Equal(expected.Type, given.Type);

            // Plan

        }
        [Fact]
        public void TestListPlans() {
            RunTest((client) => {
                var allPlans = client.Plans.ListAll();

                var resourceGroups = new System.Collections.Generic.HashSet<string>();
                allPlans.ForEach(client.Plans.ListAllNext, (plan) => {
                    resourceGroups.Add(Common.GetResourceGroupFromId(plan.Id));
                });

                resourceGroups.ForEach((rg) => {
                    client.Plans.List(rg);
                });
            });
        }
    }
}
