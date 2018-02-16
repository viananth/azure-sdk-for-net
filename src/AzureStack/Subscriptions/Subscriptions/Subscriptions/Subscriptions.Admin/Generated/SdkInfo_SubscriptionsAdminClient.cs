
using System;
using System.Collections.Generic;
using System.Linq;

internal static partial class SdkInfo
{
    public static IEnumerable<Tuple<string, string, string>> ApiInfo_SubscriptionsAdminClient
    {
        get
        {
            return new Tuple<string, string, string>[]
            {
                new Tuple<string, string, string>("Subscriptions", "DelegatedProviderOffers", "2015-11-01"),
                new Tuple<string, string, string>("Subscriptions", "Subscriptions", "2015-11-01"),
            }.AsEnumerable();
        }
    }
}
