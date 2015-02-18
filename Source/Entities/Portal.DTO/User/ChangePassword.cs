﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

namespace Portal.DTO.User
{
    /// <summary>
    ///     Profile e-mail password
    /// </summary>
    public class ChangePassword
    {
        public virtual string OldPassword { get; set; }

        public virtual string NewPassword { get; set; }

        public virtual string ConfirmPassword { get; set; }
    }
}