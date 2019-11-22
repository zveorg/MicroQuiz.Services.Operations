using MicroQuiz.Services.Operations.Core.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MicroQuiz.Services.Operations.Core.Models
{
    public class Step
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid Id { get; set; }
        [BsonRepresentation(BsonType.String)]
        public Guid EntityId { get; set; }
        public OperationState State { get; set; }
        public string RejectEventName { get; set; }
        public string RejectionReason { get; set; }
    }
}
