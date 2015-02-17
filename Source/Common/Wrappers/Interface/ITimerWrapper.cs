﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Wrappers.Interface
{
    public interface ITimerWrapper
    {
        double Interval { get; set; }

        Action Callback { get; set; }

        void Start();

        void Stop();

        void Close();
    }
}