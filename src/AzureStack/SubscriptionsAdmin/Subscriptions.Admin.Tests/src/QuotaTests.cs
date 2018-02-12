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
    public class QuotaTests : SubscriptionsTestBase
    {

        private void ValidateUsageAggregate(Quota ua) {
            // Resource
            Assert.NotNull(ua);
            //Assert.NotNull(ua.Id);
            //Assert.NotNull(ua.Location);
            Assert.NotNull(ua.Name);
            //Assert.NotNull(ua.Type);

            // Quota
            Assert.NotNull(ua.AllowCustomPortalBranding);
        }

        private void AssertSame(Quota expected, Quota given) {
            // Resource
            //Assert.Equal(expected.Id, given.Id);
            //Assert.Equal(expected.Location, given.Location);
            Assert.Equal(expected.Name, given.Name);
            //Assert.Equal(expected.Type, given.Type);

            // Quota
            Assert.Equal(expected.AllowCustomPortalBranding, given.AllowCustomPortalBranding);

        }
        [Fact]
        public void TestListQuotas() {
            RunTest((client) => {
                client.Quotas.List("local");
            });
        }
    }
}
