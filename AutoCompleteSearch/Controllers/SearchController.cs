using AutoCompleteSearch.Helpers;
using AutoCompleteSearch.Models.Search;
using AutoCompleteSearch.Validators.Search;
using FluentValidation.Results;
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
            //Log input params

            try
            {
                ValidationHelper.ValidateRequestModel(new SearchGithubReposRequestModelValidator(), model);

                #region  Validation code before refactoring
                //if (string.IsNullOrEmpty(model.searchKey))
                //    throw new Exception(ApplicationConstants.ErrorMessages.SearchKeyEmpty);

                //if (model.searchKey.Length >= ApplicationConstants.GitHubSearch.MaxCharCount)
                //throw new Exception(ApplicationConstants.ErrorMessages.SearchKeyToolong);
                #endregion

                //consider making sorting more dynamic if the sorting order needs to be altered
                string apiPath = $@"{ApplicationConstants.GitHubSearch.BaseUrl}{model.searchKey}&sort={model.sortFilter}&order=desc";

                GithubSearchResponseModel githubResponse = new GithubSearchResponseModel();

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("User-Agent", ApplicationConstants.GitHubSearch.UserAgent);

                HttpResponseMessage response = await client.GetAsync(apiPath);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    githubResponse = JsonConvert.DeserializeObject<GithubSearchResponseModel>(jsonString);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

                // If response has no elements, error msg handled at front end. 
                // Can consider throwing error here with errorMsg, so all messaging is in 1 place.
                return githubResponse.items.Select(m => m.name).Take(ApplicationConstants.GitHubSearch.RecordsToTake).ToList();

            }
            catch (Exception ex)
            {
                //Log error msg
                throw ex;
            }
        }


    }
}
