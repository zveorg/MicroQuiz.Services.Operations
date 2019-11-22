using AutoMapper;
using MicroQuiz.Services.Operations.Core.Events.Operation.Quiz;
using MicroQuiz.Services.Operations.Core.Events.Quiz;
using System;

namespace MicroQuiz.Services.Operations.Core.Profiles
{
    public class OperationProfile : Profile
    {
        public OperationProfile()
        {
            CreateMap<CreateQuizOperationEvent, CreateQuizEvent>();
        }
    }
}
