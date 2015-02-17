﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Portal.DTO.Trends
{
    /// <summary>
    ///     Watch DTO for trends API.
    /// </summary>
    public class TrendingWatch : Watch.Watch
    {
        public long Version { get; set; }
    }
}