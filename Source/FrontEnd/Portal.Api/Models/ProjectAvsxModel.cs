﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;
using Asp.Infrastructure.Validation;
using Portal.DTO.Common;
using Portal.Resources.Api;

namespace Portal.Api.Models
{
    public sealed class ProjectAvsxModel
    {
        /// <summary>
        ///     Avsx file.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof (ResponseMessages), ErrorMessageResourceName = "ProjectInvalidAvsxFile")]
        [AvsxFile(ErrorMessageResourceType = typeof (ResponseMessages), ErrorMessageResourceName = "ProjectInvalidAvsxFile")]
        public FileEntity Avsx { get; set; }
    }
}