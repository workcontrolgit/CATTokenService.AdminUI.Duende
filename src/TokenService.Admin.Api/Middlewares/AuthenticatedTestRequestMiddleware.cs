﻿// Copyright (c) Jan Škoruba. All Rights Reserved.
// Licensed under the Apache License, Version 2.0.

using IdentityModel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TokenService.Admin.Api.Middlewares
{
    public class AuthenticatedTestRequestMiddleware
    {
        private readonly RequestDelegate _next;
        public static readonly string TestAuthorizationHeader = "FakeAuthorization";
        public AuthenticatedTestRequestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Headers.Keys.Contains(TestAuthorizationHeader))
            {
                var token = context.Request.Headers[TestAuthorizationHeader].Single();
                var jwt = new JwtSecurityToken(token);
                var claimsIdentity = new ClaimsIdentity(jwt.Claims, JwtBearerDefaults.AuthenticationScheme, JwtClaimTypes.Name, JwtClaimTypes.Role);
                context.User = new ClaimsPrincipal(claimsIdentity);
            }

            await _next(context);
        }
    }
}







