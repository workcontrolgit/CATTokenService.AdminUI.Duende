// Copyright (c) Jan Škoruba. All Rights Reserved.
// Licensed under the Apache License, Version 2.0.

namespace TokenService.STS.Identity.Configuration
{
    public class ExternalProvidersConfiguration
    {
        public bool UseGitHubProvider { get; set; }
        public string GitHubClientId { get; set; }
        public string GitHubClientSecret { get; set; }        
        public string GitHubCallbackPath { get; set; }
        public bool UseTwitterProvider { get; set; }
        public string TwitterConsumerId { get; set; }
        public string TwitterConsumerSecret { get; set; }

        public bool UseGoogleProvider { get; set; }
        public string GoogleClientId { get; set; }
        public string GoogleClientSecret { get; set; }

        public bool UseFacebookProvider { get; set; }
        public string FacebookClientId { get; set; }
        public string FacebookClientSecret { get; set; }
        public bool UseAzureAdProvider { get; set; }
        public string AzureAdClientId { get; set; }
        public string AzureAdSecret { get; set; }
        public string AzureAdTenantId { get; set; }
        public string AzureInstance { get; set; }
        public string AzureAdCallbackPath { get; set; }
        public string AzureDomain { get; set; }
    }
}