﻿// Copyright (c) Jan Škoruba. All Rights Reserved.
// Licensed under the Apache License, Version 2.0.

using System;

namespace TokenService.Admin.Api.Dtos.Key
{
    public class KeyApiDto
    {
        public string Id { get; set; }
        public int Version { get; set; }
        public DateTime Created { get; set; }
        public string Use { get; set; }
        public string Algorithm { get; set; }
        public bool IsX509Certificate { get; set; }
    }
}







