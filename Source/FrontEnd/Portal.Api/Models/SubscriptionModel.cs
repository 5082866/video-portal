﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;
using Asp.Infrastructure.Validation;
using Portal.Domain.SubscriptionContext;
using Portal.Resources.Api;

namespace Portal.Api.Models
{
    public class SubscriptionModel : CompanySubscriptionUpdateOptions
    {
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        [NonWhiteSpaceString(ErrorMessageResourceType = typeof (ResponseMessages), ErrorMessageResourceName = "SubscriptionInvalidSiteName")]
        [StringLength(100, ErrorMessageResourceType = typeof (ResponseMessages), ErrorMessageResourceName = "ValidationValueMustNotBeGreaterThan")]
        [Required]
        public override string SiteName { get; set; }

        [StringLength(64, ErrorMessageResourceType = typeof (ResponseMessages), ErrorMessageResourceName = "ValidationValueMustNotBeGreaterThan")]
        public override string GoogleAnalyticsId { get; set; }
    }
}