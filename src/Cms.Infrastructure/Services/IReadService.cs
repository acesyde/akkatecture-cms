using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Akkatecture.Entities;

namespace Cms.Infrastructure.Services
{
    public interface IReadService<TEntity> where TEntity : IEntity
    {
        Task<TEntity> GetByIdAsync(Guid id);

        Task<IReadOnlyList<TEntity>> GetAllAsync(int skip = 0, int take = 25, IQueryable<TEntity> query = null);
    }
}
