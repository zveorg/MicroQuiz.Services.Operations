using MicroQuiz.Services.Operations.Core.Models;
using System;
using System.Threading.Tasks;

namespace MicroQuiz.Services.Operations.Core.Repositories
{
    public interface IOperationRepository
    {
        Task AddAsync(Operation operation);
        Task<Operation> GetAsync(Guid id);
        Task UpdateAsync(Operation operation);
        Task DeleteAsync(Guid id);
    }
}
