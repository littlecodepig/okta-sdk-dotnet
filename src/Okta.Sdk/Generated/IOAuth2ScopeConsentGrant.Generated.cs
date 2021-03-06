// <copyright file="IOAuth2ScopeConsentGrant.Generated.cs" company="Okta, Inc">
// Copyright (c) 2014 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

// This file was automatically generated. Don't modify it directly.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Okta.Sdk
{
    /// <summary>Represents a OAuth2ScopeConsentGrant resource in the Okta API.</summary>
    public partial interface IOAuth2ScopeConsentGrant : IResource
    {
        string ClientId { get; set; }

        DateTimeOffset? Created { get; }

        IOAuth2Actor CreatedBy { get; set; }

        string Id { get; }

        string Issuer { get; set; }

        DateTimeOffset? LastUpdated { get; }

        string ScopeId { get; set; }

        OAuth2ScopeConsentGrantSource Source { get; set; }

        OAuth2ScopeConsentGrantStatus Status { get; set; }

        string UserId { get; set; }

    }
}
