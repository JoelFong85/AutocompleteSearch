using AutoCompleteSearch.Models.Search;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web.Http;

namespace AutoCompleteSearch.Controllers
{
    public class SearchController : ApiController
    {
        [HttpPost]
        public async Task<List<string>> SearchGithubRepos([FromBody] string searchKey)
        {
            //if searchKey is null or empty
            //check if string length > 256            
            //add try catch block

            //prep data
            string githubSearchBaseUrl = ApplicationConstants.GithubSearchBaseUrl;
            string apiPath = $@"{githubSearchBaseUrl}{searchKey}";

            GithubSearchResponseModel githubResponse = new GithubSearchResponseModel();

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", ApplicationConstants.GithubUserAgent);

            HttpResponseMessage response = await client.GetAsync(apiPath);
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                githubResponse = JsonConvert.DeserializeObject<GithubSearchResponseModel>(jsonString);
            }
            //else

            // check if githubResponse is null
            return githubResponse.items.Select(m => m.full_name).ToList();
        }

    }
}
