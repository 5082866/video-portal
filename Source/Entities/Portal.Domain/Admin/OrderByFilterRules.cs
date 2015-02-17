// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Portal.Domain.Admin
{
    [Obsolete("Remove after migration to admin API")]
    public class OrderByFilterRules
    {
        public string Orderby { get; set; }
        public bool Ascending { get; set; }
        public int? Skip { get; set; }
        public int Take { get; set; }
    }
}