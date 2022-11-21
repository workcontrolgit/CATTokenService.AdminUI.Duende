﻿// Copyright (c) Jan Škoruba. All Rights Reserved.
// Licensed under the Apache License, Version 2.0.

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Skoruba.Duende.IdentityServer.Admin.BusinessLogic.Services.Interfaces;
using System.Threading.Tasks;
using TokenService.Admin.Api.Configuration.Constants;
using TokenService.Admin.Api.Dtos.Key;
using TokenService.Admin.Api.ExceptionHandling;
using TokenService.Admin.Api.Mappers;

namespace TokenService.Admin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ControllerExceptionFilterAttribute))]
    [Produces("application/json")]
    [Authorize(Policy = AuthorizationConsts.AdministrationPolicy)]
    public class KeysController : ControllerBase
    {
        private readonly IKeyService _keyService;

        public KeysController(IKeyService keyService)
        {
            _keyService = keyService;
        }

        [HttpGet]
        public async Task<ActionResult<KeysApiDto>> Get(int page = 1, int pageSize = 10)
        {
            var keys = await _keyService.GetKeysAsync(page, pageSize);
            var keysApi = keys.ToKeyApiModel<KeysApiDto>();

            return Ok(keysApi);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<KeyApiDto>> Get(string id)
        {
            var key = await _keyService.GetKeyAsync(id);

            var keyApi = key.ToKeyApiModel<KeyApiDto>();

            return Ok(keyApi);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _keyService.DeleteKeyAsync(id);

            return Ok();
        }
    }
}







