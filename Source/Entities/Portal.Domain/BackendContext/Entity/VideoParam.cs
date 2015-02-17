// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Portal.Domain.BackendContext.Entity.Base;

namespace Portal.Domain.BackendContext.Entity
{
    public class VideoParam : VideoParamBase
    {
        public int VideoWidth { get; set; }

        public int VideoHeight { get; set; }
    }
}