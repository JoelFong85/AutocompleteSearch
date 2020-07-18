using AutoCompleteSearch.Models.Search;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCompleteSearch.Validators.Search
{
    public class SearchGithubReposRequestModelValidator : AbstractValidator<SearchGithubReposRequestModel>
    {
        public SearchGithubReposRequestModelValidator()
        {
            RuleFor(model => model.searchKey)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().NotEmpty().WithMessage(ApplicationConstants.ErrorMessages.SearchKeyEmpty)
                .Length(ApplicationConstants.GitHubSearch.MinCharCount, ApplicationConstants.GitHubSearch.MaxCharCount).WithMessage(ApplicationConstants.ErrorMessages.SearchKeyToolong);

        }
    }
}