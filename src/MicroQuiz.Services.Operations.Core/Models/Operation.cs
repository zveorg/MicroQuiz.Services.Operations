using MicroQuiz.Services.Operations.Core.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace MicroQuiz.Services.Operations.Core.Models
{
    public class Operation
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }
        public OperationState State { get; set; }
        public List<Step> Steps { get; set; }
        public string RejectionReason { get; set; }
    }
}
