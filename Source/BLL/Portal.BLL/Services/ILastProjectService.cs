﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Threading.Tasks;
using Portal.DTO.Watch;

namespace Portal.BLL.Services
{
    public interface ILastProjectService
    {
        Task<List<Watch>> GetLastForExtension(int count);
        Task<List<Watch>> GetLastForTagger(int count);
    }
}