﻿// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Portal.BackEnd.Encoder.Interface;
using Portal.BackEnd.Encoder.Pipeline.Data;
using Wrappers;

namespace Portal.BackEnd.Encoder.Pipeline.Step
{
    public class InitializingWebClientStep : PipelineStep<TaskStepData>
    {
        public InitializingWebClientStep(IStepMediator stepMediator, IEncodeWebClient encodeWebClient)
            : base(stepMediator, encodeWebClient)
        {
            stepMediator.AddInitializingWebClientStep(this);
        }

        public override void Execute(CancellationTokenSourceWrapper tokenSource)
        {
            WebClient.Initialize(StepData.Resource, StepData.TaskId, tokenSource);
        }
    }
}