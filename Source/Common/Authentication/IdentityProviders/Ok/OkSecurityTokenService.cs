﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IdentityModel;
using System.IdentityModel.Configuration;
using System.IdentityModel.Protocols.WSTrust;
using System.IdentityModel.Services;
using System.Security.Claims;
using Configuration;
using OkSdk;

namespace Authentication.IdentityProviders.Ok
{
    public sealed class OkSecurityTokenService : SecurityTokenService, IIdentityProvider
    {
        private const string WtRealm = "https://{0}.accesscontrol.windows.net/";
        private const string WReply = "https://{0}.accesscontrol.windows.net/v2/wsfederation";
        private readonly IPortalFrontendSettings _settings;

        public OkSecurityTokenService(SecurityTokenServiceConfiguration configuration, IPortalFrontendSettings settings)
            : base(configuration)
        {
            _settings = settings;
        }

        public Uri GetAutheticationUri(IDictionary<string, string> parameters, Uri callback)
        {
            var callbackUri = new UriBuilder(callback)
            {
                Query = string.Format("context={0}", parameters["wctx"])
            };

            // Pass your credentials to the service
            string appId = _settings.OkApplicationId;
            string appSecret = _settings.OkApplicationSecret;
            string appPublic = _settings.OkApplicationPublic;

            var service = new OkClient(appId, appSecret, appPublic);

            // Redirect to the OAuth Authorization URL
            return service.GetAuthorizationUri(string.Empty, callbackUri.ToString());
        }

        public string GetResponseHtml(IDictionary<string, string> parameters, Uri signinUri)
        {
            string code = parameters["code"];

            // Exchange the Request Token for an Access Token
            string appId = _settings.OkApplicationId;
            string appSecret = _settings.OkApplicationSecret;
            string appPublic = _settings.OkApplicationPublic;

            string scheme = parameters["SERVER_PORT_SECURE"] == "1" ? "https" : "http";

            var callbackUri = new UriBuilder(string.Format("{0}://{1}", scheme, parameters["HTTP_HOST"]))
            {
                Path = parameters["URL"],
                Query = string.Format("context={0}", parameters["context"])
            };

            var service = new OkClient(appId, appSecret, appPublic);
            dynamic accessToken = service.GetAccessToken(code, callbackUri.ToString());

            dynamic token = accessToken.access_token;
            service.AuthenticateWith(token.ToString());

            // Claims
            dynamic user = service.Get("users.getCurrentUser");

            string acsNamespace = _settings.AcsNamespace;
            string wtRealm = string.Format(WtRealm, acsNamespace);
            string wReply = string.Format(WReply, acsNamespace);

            var requestMessage = new SignInRequestMessage(signinUri, wtRealm, wReply);

            // Add extracted claims
            var identity = new ClaimsIdentity(AuthenticationTypes.Federation);
            identity.AddClaim(new Claim(ClaimTypes.Name, user.name.ToString()));
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.uid.ToString()));
            identity.AddClaim(new Claim(OkClaims.OkToken, token.ToString()));

            var principal = new ClaimsPrincipal(identity);

            SignInResponseMessage responseMessage = FederatedPassiveSecurityTokenServiceOperations.ProcessSignInRequest(requestMessage, principal, this);
            responseMessage.Context = parameters["context"];

            return responseMessage.WriteFormPost();
        }

        protected override Scope GetScope(ClaimsPrincipal principal, RequestSecurityToken request)
        {
            if (request.AppliesTo == null)
            {
                throw new InvalidRequestException("The AppliesTo is null.");
            }

            var scope = new Scope(request.AppliesTo.Uri.OriginalString, SecurityTokenServiceConfiguration.SigningCredentials)
            {
                TokenEncryptionRequired = false,
                SymmetricKeyEncryptionRequired = false
            };

            scope.ReplyToAddress = string.IsNullOrEmpty(request.ReplyTo) ? scope.AppliesToAddress : request.ReplyTo;

            return scope;
        }

        protected override ClaimsIdentity GetOutputClaimsIdentity(ClaimsPrincipal principal, RequestSecurityToken request, Scope scope)
        {
            if (principal == null)
            {
                throw new InvalidRequestException("The caller's principal is null.");
            }

            var claimsIdentity = principal.Identity as ClaimsIdentity;
            if (claimsIdentity == null)
            {
                throw new InvalidRequestException("The caller's identity is invalid.");
            }

            return claimsIdentity;
        }
    }
}