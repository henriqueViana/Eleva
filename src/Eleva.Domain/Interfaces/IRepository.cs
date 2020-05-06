using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Eleva.Domain.Models;

namespace Eleva.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        Task<int> Create(TEntity entity);
        Task<int> Update(TEntity entity);
        Task<int> Destroy(Guid id);
    }
}
