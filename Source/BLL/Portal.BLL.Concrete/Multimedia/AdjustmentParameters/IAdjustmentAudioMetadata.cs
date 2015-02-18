// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3. See License.txt in the project root for license information.

namespace Portal.BLL.Concrete.Multimedia.AdjustmentParameters
{
    public interface IAdjustmentAudioMetadata
    {
        string AdjustAudioCodec(string mediaContainer, string audioCodec);
        int AdjustAudioBitrate(int size, int audioChannel, int audioBitrate, int audioSampleRate);
    }
}