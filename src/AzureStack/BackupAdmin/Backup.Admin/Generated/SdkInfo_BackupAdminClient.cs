
using System;
using System.Collections.Generic;
using System.Linq;

internal static partial class SdkInfo
{
    public static IEnumerable<Tuple<string, string, string>> ApiInfo_BackupAdminClient
    {
        get
        {
            return new Tuple<string, string, string>[]
            {
                new Tuple<string, string, string>("Backup.Admin", "BackupLocations", "2016-05-01"),
                new Tuple<string, string, string>("Backup.Admin", "Backups", "2016-05-01"),
                new Tuple<string, string, string>("Backup.Admin", "Operations", "2016-05-01"),
            }.AsEnumerable();
        }
    }
}
