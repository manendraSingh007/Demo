// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> Apis =>
            new List<ApiResource>
            {
                new ApiResource("DoverAPI", "Dover API")
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "3MVG94DzwlYDSHS6B5bFeFUVIoy66rr126OFeDQdsX2AoXRJcri1t86UWhTMP92T6vH75IhFGxSHTPw2QofVx",

                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowAccessTokensViaBrowser=true,

                    // secret for authentication
                    ClientSecrets =
                    {
                        new Secret("233DE275FE143BAEEC934AD2BEF159DE31F5BEF2CE00922FBEE8EA3E23A1E567".Sha256())
                    },

                    // scopes that client has access to
                    AllowedScopes = { "DoverAPI" }
                }
            };
    }
}