﻿using Ryujinx.HLE.HOS.Kernel.Threading;
using System;
using System.Buffers;

namespace Ryujinx.HLE.HOS.Services.Audio.AudioRenderer
{
    interface IAudioRenderer : IDisposable
    {
        uint GetSampleRate();
        uint GetSampleCount();
        uint GetMixBufferCount();
        int GetState();
        ResultCode RequestUpdate(Memory<byte> output, Memory<byte> performanceOutput, ReadOnlySequence<byte> input);
        ResultCode Start();
        ResultCode Stop();
        ResultCode QuerySystemEvent(out KEvent systemEvent);
        void SetRenderingTimeLimit(uint percent);
        uint GetRenderingTimeLimit();
        ResultCode ExecuteAudioRendererRendering();
        void SetVoiceDropParameter(float voiceDropParameter);
        float GetVoiceDropParameter();
    }
}
