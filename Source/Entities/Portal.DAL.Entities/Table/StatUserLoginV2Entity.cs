﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using MongoRepository;

namespace Portal.DAL.Entities.Table
{
    [CollectionName("StatUserLoginV2")]
    public class StatUserLoginV2Entity : Entity
    {
        public string ProductName { get; set; }

        public string IdentityProvider { get; set; }

        public string UserId { get; set; }
    }
}