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
        public async Task<List<string>> SearchGithubRepos([FromBody] SearchGithubReposRequestModel model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.searchKey))
                    throw new Exception(ApplicationConstants.ErrorMessages.SearchKeyEmpty);

                if (model.searchKey.Length >= ApplicationConstants.GitHubSearch.MaxCharCount)
                    throw new Exception(ApplicationConstants.ErrorMessages.SearchKeyToolong);

                //prep data
                string githubSearchBaseUrl = ApplicationConstants.GitHubSearch.BaseUrl;
                string apiPath = $@"{githubSearchBaseUrl}{model.searchKey}";

                GithubSearchResponseModel githubResponse = new GithubSearchResponseModel();

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("User-Agent", ApplicationConstants.GitHubSearch.UserAgent);

                HttpResponseMessage response = await client.GetAsync(apiPath);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    githubResponse = JsonConvert.DeserializeObject<GithubSearchResponseModel>(jsonString);
                }
                //else

                // what to do if response has no elements
                return githubResponse.items.Select(m => m.name).Take(ApplicationConstants.GitHubSearch.RecordsToTake).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
