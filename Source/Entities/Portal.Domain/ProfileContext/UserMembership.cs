﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

namespace Portal.Domain.ProfileContext
{
    public class UserMembership
    {
        public ProviderType IdentityProvider { get; set; }

        public string UserIdentifier { get; set; }

        public string Token { get; set; }

        public string TokenSecret { get; set; }
    }
}