﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;
using Swashbuckle.Swagger;

namespace DiagnosticSystem.WebApi.App_Start.Swagger
{
    public class AuthorizationOperationFilter : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            operation.parameters.Add(new Parameter()
            {
                type = "stirng",
                name = "Authorization",
                @in = "header",
                description = "access token",
                @default = "Bearer ",
                required = false
            });

        }
    }
}