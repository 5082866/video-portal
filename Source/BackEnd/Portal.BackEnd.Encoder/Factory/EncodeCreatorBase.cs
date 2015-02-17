// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Portal.BackEnd.Encoder.Ffmpeg;
using Portal.BackEnd.Encoder.Interface;

namespace Portal.BackEnd.Encoder.Factory
{
    public abstract class EncodeCreatorBase
    {
        public IDataReceivedHandler CreateDataReceivedHandler(IFfmpegParser parser)
        {
            return new DataReceivedHandler(parser);
        }
    }
}