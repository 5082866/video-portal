﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Portal.DTO.Reports;

namespace Portal.BLL.Statistics.Reporter
{
    public interface IStandardReportBuilder
    {
        Task<StandardReport> BuildReport(DateTime dateTime);
        IEnumerable<Report> BuildReports(DateTime start, DateTime end);
    }
}