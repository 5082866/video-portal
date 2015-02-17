﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Portal.BLL.Statistics.Filter;
using Portal.Domain.StatisticContext;

namespace Portal.BLL.Concrete.Statistics.Filter.Filters.DailyMotion
{
    public class DailyMotionCancellationFilter : StatFilterBase<IStatProjectCancellationFilter>, IStatProjectCancellationFilter
    {
        public void Call(DomainStatProjectState domainStatProjectState, DomainReport domainReport)
        {
            if (!domainStatProjectState.IsSuccessfulUpload &&
                domainStatProjectState.Producer == ProductName.DailyMotion)
            {
                domainReport.DailyMotionUploadCancels++;
            }
            if (Filter != null)
            {
                Filter.Call(domainStatProjectState, domainReport);
            }
        }
    }
}