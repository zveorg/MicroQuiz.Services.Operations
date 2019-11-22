namespace MicroQuiz.Services.Operations.Infrastructure.Mongo
{
    public class MongoOptions : IMongoOptions
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
