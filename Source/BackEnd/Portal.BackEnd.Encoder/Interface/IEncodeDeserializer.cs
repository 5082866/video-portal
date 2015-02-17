// Copyright (c) Clickberry, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Portal.Domain.BackendContext.Entity;
using Portal.Domain.BackendContext.Entity.Base;
using Portal.Domain.BackendContext.Enum;
using RestSharp;

namespace Portal.BackEnd.Encoder.Interface
{
    public interface IEncodeDeserializer
    {
        EncodeTaskData EncodeTaskDataDeserealize(IRestResponse response);
        IEncodeData EncodeDataDeserialize(IRestResponse response, TypeOfTask typeOfTask);
    }
}