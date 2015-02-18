﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using Portal.BLL.Statistics.Filter;
using Portal.Domain.StatisticContext;

namespace Portal.BLL.Concrete.Statistics.Filter.Filters.CicPc
{
    public class CicPcUploadsFilter : StatFilterBase<IStatProjectUploadingFilter>, IStatProjectUploadingFilter
    {
        public void Call(DomainStatProjectState domainStatProjectState, DomainReport domainReport)
        {
            if (domainStatProjectState.IsSuccessfulUpload &&
                domainStatProjectState.Producer == ProductName.CicPc)
            {
                domainReport.CicPcSuccessfulUploads++;
            }
            if (Filter != null)
            {
                Filter.Call(domainStatProjectState, domainReport);
            }
        }
    }
}