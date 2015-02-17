﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Portal.Domain.SubscriptionContext
{
    public class DomainBalanceHistory
    {
        public string Id { get; set; }

        public string CompanyId { get; set; }

        public decimal Amount { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}