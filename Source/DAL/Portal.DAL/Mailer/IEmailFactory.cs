﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

namespace Portal.DAL.Mailer
{
    public interface IEmailFactory
    {
        IEmailBuilder CreateEmailBuilder();
        IMailClient CreateMailClient();
    }
}