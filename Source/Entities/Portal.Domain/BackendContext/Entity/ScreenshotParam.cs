// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using Portal.Domain.BackendContext.Entity.Base;

namespace Portal.Domain.BackendContext.Entity
{
    public class ScreenshotParam : ScreenshotParamBase
    {
        /// <summary>
        ///     Time offset from the begining of the video file in seconds.
        /// </summary>
        public double TimeOffset { get; set; }
    }
}