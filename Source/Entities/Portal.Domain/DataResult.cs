﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Portal.Domain
{
    public sealed class DataResult<T> where T : class
    {
        public DataResult(IEnumerable<T> results, long? count = null)
        {
            Results = results;
            Count = count;
        }

        /// <summary>
        ///     Paged result collection.
        /// </summary>
        public IEnumerable<T> Results { get; private set; }

        /// <summary>
        ///     Total count of results.
        /// </summary>
        public long? Count { get; private set; }
    }
}