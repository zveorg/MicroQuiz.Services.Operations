namespace MicroQuiz.Services.Operations.Infrastructure.Mongo
{
    public interface IMongoOptions
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
    }
}
