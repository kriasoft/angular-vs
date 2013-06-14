// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomBodyModelValidator.cs" company="KriaSoft LLC">
//   Copyright © 2013 Konstantin Tarkus, KriaSoft LLC. See LICENSE.txt
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.Validation
{
    using System;
    using System.Web.Http.Controllers;
    using System.Web.Http.Metadata;
    using System.Web.Http.Validation;

    public class CustomBodyModelValidator : IBodyModelValidator
    {
        private readonly IBodyModelValidator validator;

        public CustomBodyModelValidator(IBodyModelValidator validator)
        {
            this.validator = validator;
        }

        public bool Validate(object model, Type type, ModelMetadataProvider metadataProvider, HttpActionContext actionContext, string keyPrefix)
        {
            return this.validator.Validate(model, type, metadataProvider, actionContext, string.Empty);
        }
    }
}