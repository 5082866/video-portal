﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Portal.Domain.ProjectContext;

namespace Portal.Domain.Admin
{
    public sealed class DomainUserForAdmin
    {
        public string AppName { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public DateTime Created { get; set; }

        public long UsedStorageSpace { get; set; }

        public long MaximumStorageSpace { get; set; }

        public int VideosCount { get; set; }

        public List<DomainUserMembershipForAdmin> Memberships { get; set; }

        public ProductType ProductType { get; set; }

        public string ProductName { get; set; }
    }
}