﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using System;

namespace Portal.Domain.AccountContext
{
    public class RecoveryLink
    {
        public string Id { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}