// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

using Portal.BackEnd.Encoder.Interface;

namespace Portal.BackEnd.Encoder.Ffmpeg
{
    public class ScreenshotFfmpegParser : IFfmpegParser
    {
        public double ParseDuration(string str)
        {
            return 1;
        }

        public double ParseEncodeTime(string str)
        {
            return 0;
        }
    }
}