// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//

using Microsoft.AzureStack.Management.AzureBridge.Admin;
using Microsoft.AzureStack.Management.AzureBridge.Admin.Models;
using System;
using Xunit;

namespace AzureBridge.Tests
{
    public class ActivationTests : AzureBridgeTestBase
    {
        [Fact]
        public void TestListActivations() {
            RunTest((client) => {
                var list = client.Activations.List("azurestack-activation");
                Common.WriteIPagesToFile(list, client.Activations.ListNext, "TestListActivations");
            });
        }

        [Fact]
        public void TestGetNonExistantActication()
        {
            RunTest((client) => {
                var activation = client.Activations.Get("azurestack-activation","nonexsting-activation");
                Assert.Null(activation);
            });
        }

    }
}
