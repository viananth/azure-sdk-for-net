// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using System.Linq;

using Microsoft.AzureStack.Management.Subscriptions.Admin;
using Microsoft.AzureStack.Management.Subscriptions.Admin.Models;
using System;
using Xunit;

namespace Subscriptions.Tests
{
    public class AcquiredPlanTests : SubscriptionsTestBase
    {

        private void ValidateAcquiredPlan(AcquiredPlan ua) {
            // Resource
            Assert.NotNull(ua);
            Assert.NotNull(ua.Id);
            Assert.NotNull(ua.Location);
            Assert.NotNull(ua.Name);
            Assert.NotNull(ua.Type);

            // AcquiredPlan
            Assert.NotNull(ua.AcquisitionId);
            Assert.NotNull(ua.AcquisitionTime);
            Assert.NotNull(ua.ExternalReferenceId);
            Assert.NotNull(ua.PlanId);
            Assert.NotNull(ua.ProvisioningState);
        }

        private void AssertSame(AcquiredPlan expected, AcquiredPlan given) {
            // Resource
            Assert.Equal(expected.Id, given.Id);
            Assert.Equal(expected.Location, given.Location);
            Assert.Equal(expected.Name, given.Name);
            Assert.Equal(expected.Type, given.Type);

            // AcquiredPlan
            Assert.Equal(expected.AcquisitionId, given.AcquisitionId);
            Assert.Equal(expected.AcquisitionTime, given.AcquisitionTime);
            Assert.Equal(expected.ExternalReferenceId, given.ExternalReferenceId);
            Assert.Equal(expected.PlanId, given.PlanId);
            Assert.Equal(expected.ProvisioningState, given.ProvisioningState);
        }

        [Fact]
        public void TestListAcquiredPlans() {
            RunTest((client) => {
                var subscriptions = client.Subscriptions.List();
                subscriptions.ForEach((subscription) => {
                    var acquiredPlans = client.AcquiredPlans.List(subscription.DelegatedProviderSubscriptionId);
                    Common.MapOverIPage(acquiredPlans, client.AcquiredPlans.ListNext, ValidateAcquiredPlan);
                });
            });
        }

        [Fact]
        public void TestGetAllAcquiredPlans() {
            RunTest((client) => {
                var subscriptions = client.Subscriptions.List();
                subscriptions.ForEach((subscription) => {
                    var acquiredPlans = client.AcquiredPlans.List(subscription.DelegatedProviderSubscriptionId);
                    Common.MapOverIPage(acquiredPlans, client.AcquiredPlans.ListNext, (aPlan) => {
                        var result = client.AcquiredPlans.Get(subscription.DelegatedProviderSubscriptionId, aPlan.Name);
                        AssertSame(aPlan, result);
                    });
                });
            });
        }

        [Fact]
        public void TestGetAcquiredPlan() {
            RunTest((client) => {
                var subscription = client.Subscriptions.List().FirstOrDefault();
                var acquiredPlan = client.AcquiredPlans.List(subscription.DelegatedProviderSubscriptionId).First();
                var result = client.AcquiredPlans.Get(subscription.DelegatedProviderSubscriptionId, acquiredPlan.Name);
                AssertSame(acquiredPlan, result);
            });
        }

        [Fact]
        public void TestCreateThenDeleteAcquiredPlan() {
            RunTest((client) => {
                var subscription = client.Subscriptions.List().FirstOrDefault();
                var plan = client.Plans.ListAll().First();

                var newPlan = new AcquiredPlanProperties()
                {
                    AcquisitionId = Guid.NewGuid().ToString(),
                    PlanId = plan.Id
                };

                var result = client.AcquiredPlans.Create(subscription.DelegatedProviderSubscriptionId, newPlan.AcquisitionId, newPlan);
                client.AcquiredPlans.Delete(subscription.DelegatedProviderSubscriptionId, newPlan.AcquisitionId);

                result = client.AcquiredPlans.Get(subscription.DelegatedProviderSubscriptionId, newPlan.AcquisitionId);
                Assert.Null(result);

            });
        }
    }
}
