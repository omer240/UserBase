using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserBase.Domain.Entities.Identity.Common;

namespace UserBase.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task<T> AddRanceAsync(List<T> entities);
        T Update(T entity);
        T UpdateRange(List<T> entity);
        bool Remove(T entity);
        bool RemoveRange(List<T> entities);
        Task<int> SaveAsync();
    }
}
