﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Portal.Domain.RoleContext;

namespace Portal.BLL.Services
{
    public interface IPortalRoleService
    {
        List<DomainRole> GetAdminRoles();
    }
}