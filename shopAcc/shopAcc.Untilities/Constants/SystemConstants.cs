using System;
using System.Collections.Generic;
using System.Text;

namespace shopAcc.Utilities.Constants
{
    public class SystemConstants
    {
        public const string MainConnectionString = "shopSolutionDb";
        public const string CartSession = "CartSession";

        public class AppSettings
        {
            public const string DefaultName = "DefaultName";
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
        }

        public class AccountSettings
        {
            public const int NumberOfFeaturedAccounts = 6;
            public const int NumberOfLatestAccounts = 20;
        }

        public class ProductConstants
        {
            public const string NA = "N/A";
        }
    }
}