using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCompleteSearch.Helpers
{
    public class ValidationHelper
    {
        public static void ValidateRequestModel(dynamic validator, dynamic model)
        {
            ValidationResult vr = validator.Validate(model);
            if (!vr.IsValid)
            {
                string errorMsg = string.Empty;
                foreach (ValidationFailure failure in vr.Errors)
                {
                    errorMsg += failure.ErrorMessage;
                }
                throw new Exception(errorMsg);
            }
        }

    }
}