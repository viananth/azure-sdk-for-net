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
    public class OfferTests : SubscriptionsTestBase
    {
 
        private void ValidateOffer(Offer ua) {
            // Resource
            Assert.NotNull(ua);
            Assert.NotNull(ua.Id);
            Assert.NotNull(ua.Location);
            Assert.NotNull(ua.Name);
            Assert.NotNull(ua.Type);

            // Offer
        }

        private void AssertSame(Offer expected, Offer given) {
            // Resource
            Assert.Equal(expected.Id, given.Id);
            Assert.Equal(expected.Location, given.Location);
            Assert.Equal(expected.Name, given.Name);
            Assert.Equal(expected.Type, given.Type);

            // Offer
        }

        public void TestListAllOffers() {
            RunTest((client) => {
                var allOffers = client.Offers.ListAll();
                allOffers.ForEach(client.Offers.ListAllNext, ValidateOffer);
            });
            }

        [Fact]
        public void TestListOffers() {
            RunTest((client) => {
                var allOffers = client.Offers.ListAll();
                var resourceGroups = new System.Collections.Generic.HashSet<string>();
                allOffers.ForEach(client.Offers.ListAllNext, (offer) => {
                    resourceGroups.Add(Common.GetResourceGroupFromId(offer.Id));
                });

                resourceGroups.ForEach((rg) => {
                    var offers = client.Offers.List(rg);
                    offers.ForEach(client.Offers.ListNext, ValidateOffer);
                });

            });
        }
        
        [Fact]
        public void TestGetAllOffers() {
            RunTest((client) => {
                var allOffers = client.Offers.ListAll();
                var resourceGroups = new System.Collections.Generic.HashSet<string>();
                allOffers.ForEach(client.Offers.ListAllNext, (offer) => {
                    resourceGroups.Add(Common.GetResourceGroupFromId(offer.Id));
                });

                resourceGroups.ForEach((rg) => {
                    client.Offers.List(rg).ForEach(client.Offers.ListNext, (offer) => {
                        var result = client.Offers.Get(rg, offer.Name);
                        AssertSame(offer, result);
                    });
                });
            });
        }

        [Fact]
        public void TestGetOffer() {
            RunTest((client) => {
                var offer = client.Offers.ListAll().GetFirst();
                var rg = Common.GetResourceGroupFromId(offer.Id);
                var result = client.Offers.Get(rg, offer.Name);
                AssertSame(offer, result);
            });
        }

        [Fact]
        public void TestCreateUpdateThenDeleteOffer() {
            RunTest((client) => {
                var offerName = "testOffer";
                var plan = client.Plans.ListAll().First();
                var offer = new Offer()
                {
                    Description = "This is a test plan",
                    DisplayName = "Test plan",
                    MaxSubscriptionsPerAccount = 100,
                    BasePlanIds = new System.Collections.Generic.List<string>() {plan.Id}
                };
                
                var result = client.Offers.CreateOrUpdate("jeff", offerName, offer);
                client.Offers.Delete("jeff" , offerName);

                
            });
        }
    }
}
