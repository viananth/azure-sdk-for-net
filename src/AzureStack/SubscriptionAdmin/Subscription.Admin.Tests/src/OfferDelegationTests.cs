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
    public class DelegatedOfferTests : SubscriptionsTestBase
    {

        private void ValidateDelegatedOffer(DelegatedOffer item) {
            // Resource
            Assert.NotNull(item);
            Assert.NotNull(item.Id);
            Assert.NotNull(item.Location);
            Assert.NotNull(item.Name);
            Assert.NotNull(item.Type);

            // DelegatedOffer
            Assert.NotNull(item.OfferDescription);
            Assert.NotNull(item.OfferDisplayName);
            Assert.NotNull(item.OfferName);
            Assert.NotNull(item.OfferResourceGroupName);
            Assert.NotNull(item.ResellerOfferDescription);
            Assert.NotNull(item.ResellerOfferDisplayName);
            Assert.NotNull(item.ResellerOfferName);
            Assert.NotNull(item.ResellerOfferResourceGroupName);
            Assert.NotNull(item.ResellerSubscriptionId);
            Assert.NotNull(item.SubscriptionId);
        }

        private void AssertSame(DelegatedOffer expected, DelegatedOffer given) {
            // Resource
            Assert.Equal(expected.Id, given.Id);
            Assert.Equal(expected.Location, given.Location);
            Assert.Equal(expected.Name, given.Name);
            Assert.Equal(expected.Type, given.Type);

            // DelegatedOffer
        }

        [Fact]
        public void TestListDelegatedOffers() {
            RunTest((client) => {
                var offers = client.Offers.ListAll();
                Common.MapOverIPage(offers, client.Offers.ListAllNext, (offer) => {
                    var resourceGroup = Common.GetResourceGroupFromId(offer.Id);
                    var offerDelegations = client.OfferDelegations.List(resourceGroup, offer.Name);
                    offerDelegations.ForEach(client.OfferDelegations.ListNext, ValidateDelegatedOffer);
                });
            });
        }

        [Fact]
        public void TestListAllDelegatedOffers() {
            RunTest((client) => {
                var offers = client.Offers.ListAll();
                Common.MapOverIPage(offers, client.Offers.ListAllNext, (offer) => {
                    var resourceGroup = Common.GetResourceGroupFromId(offer.Id);
                    var offerDelegations = client.OfferDelegations.List(resourceGroup, offer.Name);
                    offerDelegations.ForEach(client.OfferDelegations.ListNext, (dOffer) => {
                        var result = client.OfferDelegations.Get(resourceGroup, offer.Name, dOffer.Name);
                        AssertSame(dOffer, result);
                    });
                });
            });
        }

        [Fact]
        public void TestGetDelegatedOffer() {
            RunTest((client) => {
                var offer = client.Offers.ListAll().GetFirst();
                var resourceGroup = Common.GetResourceGroupFromId(offer.Id);
                var offerDelegation = client.OfferDelegations.List(resourceGroup, offer.Name).GetFirst();
                var result = client.OfferDelegations.Get(resourceGroup, offer.Name, offerDelegation.Name);
                AssertSame(offerDelegation, result);
            });
        }

        [Fact]
        public void TestCreateUpdateThenDeleteDelegatedOffer() {
            RunTest((client) => {
                var offer = client.Offers.ListAll().GetFirst();
                var resourceGroup = Common.GetResourceGroupFromId(offer.Id);
                
                var dOffer = new DelegatedOffer()
                {
                    
                };

                var result = client.OfferDelegations.CreateOrUpdate(resourceGroup, offer.Name, "testDelegatedOffer", dOffer);
            });
        }

    }
}
