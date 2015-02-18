﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using System;
using AutoMapper;
using Cassandra;
using Portal.Common.Helpers;
using Portal.DAL.Entities.Statistics;

namespace Portal.Mappers.Mappings.Statistics
{
    public class TimeSeriesRollupsHourMapping : IMapping
    {
        private readonly string _countPropertyName = NameOfHelper.PropertyName<TimeSeriesRollupsHourEntity>(x => x.Count);
        private readonly string _hourPropertyName = NameOfHelper.PropertyName<TimeSeriesRollupsHourEntity>(x => x.Hour);
        private readonly string _rowKeyPropertyName = NameOfHelper.PropertyName<TimeSeriesRollupsHourEntity>(x => x.EventIdDd);

        public void Register()
        {
            Mapper.CreateMap<Row, TimeSeriesRollupsHourEntity>()
                .ForMember(d => d.EventIdDd, o => o.MapFrom(row => row.GetValue<string>(_rowKeyPropertyName)))
                .ForMember(d => d.Hour, o => o.MapFrom(row => row.GetValue<DateTimeOffset>(_hourPropertyName)))
                .ForMember(d => d.Count, o => o.MapFrom(row => !row.IsNull(_countPropertyName) ? row.GetValue<long>(_countPropertyName) : 0))
                ;
        }
    }
}