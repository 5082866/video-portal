﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

namespace Portal.Domain.BillingContext
{
    public class DomainCardCreateOptions
    {
        public string CustomerId { get; set; }

        public string TokenId { get; set; }
    }
}