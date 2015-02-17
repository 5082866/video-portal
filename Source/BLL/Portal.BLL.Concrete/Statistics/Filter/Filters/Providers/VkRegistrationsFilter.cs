﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Portal.BLL.Statistics.Filter;
using Portal.Domain.ProfileContext;
using Portal.Domain.StatisticContext;

namespace Portal.BLL.Concrete.Statistics.Filter.Filters.Providers
{
    public class VkRegistrationsFilter : StatFilterBase<IStatUserRegistrationFilter>, IStatUserRegistrationFilter
    {
        public void Call(DomainStatUserRegistration domainStatUserRegistration, DomainReport domainReport)
        {
            if (domainStatUserRegistration.IdentityProvider == ProviderType.Vk.ToString())
            {
                domainReport.VkRegistrations++;
            }
            if (Filter != null)
            {
                Filter.Call(domainStatUserRegistration, domainReport);
            }
        }
    }
}