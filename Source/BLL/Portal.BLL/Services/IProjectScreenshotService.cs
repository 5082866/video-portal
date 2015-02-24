﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Portal.Domain.ProjectContext;

namespace Portal.BLL.Services
{
    public interface IProjectScreenshotService
    {
        Task<DomainScreenshot> AddAsync(string projectId, DomainScreenshot entity);

        Task<DomainScreenshot> GetAsync(string projectId);

        Task DeleteAsync(string projectId);
    }
}