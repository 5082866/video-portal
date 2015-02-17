﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace LinkTracker.BLL.Infrastructure
{
    public interface IUrlShortenerService
    {
        string Encode(long number);

        long Decode(string str);
    }
}