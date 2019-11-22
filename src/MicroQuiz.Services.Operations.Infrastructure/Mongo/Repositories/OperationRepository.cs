using MicroQuiz.Services.Operations.Core.Models;
using MicroQuiz.Services.Operations.Core.Repositories;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace MicroQuiz.Services.Operations.Infrastructure.Mongo.Repositories
{
    public class OperationRepository : IOperationRepository
    {
        private readonly IMongoDatabase _database;

        private IMongoCollection<Operation> _operations
            => _database.GetCollection<Operation>("operations");


        public OperationRepository(IMongoDatabase database)
            => _database = database;

        public async Task AddAsync(Operation operation)
            => await _operations.InsertOneAsync(operation);

        public async Task DeleteAsync(Guid id)
            => await _operations.DeleteOneAsync(x => x.Id == id);

        public async Task<Operation> GetAsync(Guid id)
            => await _operations.Find(x => x.Id == id).SingleOrDefaultAsync();

        public async Task UpdateAsync(Operation operation)
        {
            var filter = Builders<Operation>.Filter.Eq(s => s.Id, operation.Id);
            var result = await _operations.ReplaceOneAsync(filter, operation);
        }
    }
}
