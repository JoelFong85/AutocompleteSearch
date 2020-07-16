using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCompleteSearch.Models.Search
{
    public class SearchItems
    {
        public int id { get; set; }
        public string node_id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public bool @private { get; set; }
        public Owner owner { get; set; }
        public string html_url { get; set; }
        public string description { get; set; }
        public bool fork { get; set; }
        public string url { get; set; }
        public string forks_url { get; set; }
        public string keys_url { get; set; }
        public string collaborators_url { get; set; }
        public string teams_url { get; set; }
        public string hooks_url { get; set; }
        public string issue_events_url { get; set; }
        public string events_url { get; set; }
        public string assignees_url { get; set; }
        public string branches_url { get; set; }
        public string tags_url { get; set; }
        public string blobs_url { get; set; }
        public string git_tags_url { get; set; }
        public string git_refs_url { get; set; }
        public string trees_url { get; set; }
        public string statuses_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        //public string blobs_url { get; set; }
        public string language { get; set; }

    }
}