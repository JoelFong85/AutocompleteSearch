using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCompleteSearch.Models.Search
{
    public class GithubSearchResponseModel
    {
        public int total_count { get; set; }
        public bool incomplete_results { get; set; }
        public List<SearchItems> items { get; set; }
    }
}