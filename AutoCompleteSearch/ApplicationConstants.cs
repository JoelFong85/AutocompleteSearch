using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCompleteSearch
{
    public class ApplicationConstants
    {
        public struct GitHubSearch
        {
            public const string BaseUrl = "https://api.github.com/search/repositories?q=";
            public const string UserAgent = "JoelFong85";
            public const int RecordsToTake = 10;
            public const int MinCharCount = 1;
            public const int MaxCharCount = 256;
        }

        public struct ErrorMessages
        {
            public const string SearchKeyEmpty = "Please try re-entering a search term";
            public const string SearchKeyToolong = "Please try reducing the length of your search term";
            public const string RateLimitExceeded = "Please try again in a minute";
        }


    }
}