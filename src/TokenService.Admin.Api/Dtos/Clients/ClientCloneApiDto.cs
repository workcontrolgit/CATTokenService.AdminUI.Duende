﻿// Copyright (c) Jan Škoruba. All Rights Reserved.
// Licensed under the Apache License, Version 2.0.

using System.ComponentModel.DataAnnotations;

namespace TokenService.Admin.Api.Dtos.Clients
{
    public class ClientCloneApiDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string ClientId { get; set; }

        [Required]
        public string ClientName { get; set; }

        [Required]
        public bool CloneClientCorsOrigins { get; set; }

        [Required]
        public bool CloneClientRedirectUris { get; set; }

        [Required]
        public bool CloneClientIdPRestrictions { get; set; }

        [Required]
        public bool CloneClientPostLogoutRedirectUris { get; set; }

        [Required]
        public bool CloneClientGrantTypes { get; set; }

        [Required]
        public bool CloneClientScopes { get; set; }

        [Required]
        public bool CloneClientClaims { get; set; }

        [Required]
        public bool CloneClientProperties { get; set; }
    }
}







