using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UserBase.Application.Responses;
using UserBase.Domain.Entities.Identity.Common;

namespace UserBase.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<List<TResult>> ListAsync<TResult>(
                Expression<Func<T, bool>>? expression = null,
                Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                int? skip = null,
                int? take = null,
                bool tracking = false,
                CancellationToken ct = default,
                Expression<Func<T, TResult>>? selector = null,
                params Expression<Func<T, object>>[] includes
            );
        Task<PagedResponse<TResult>> PagedAsync<TResult>(
                int page, int pageSize,
                Expression<Func<T, bool>>? expression = null,
                Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                bool tracking = false,
                CancellationToken ct = default,
                Expression<Func<T, TResult>>? selector = null,
                params Expression<Func<T, object>>[] includes
            );


        IQueryable<T> GetAll(Expression<Func<T,bool>> expression, bool tracking = false);
        IQueryable<T> GetWhere(Expression<Func<T,bool>> expression, bool tracking = false);
        Task<T> GetByIdAsync(string id, bool tracking = true, CancellationToken ct = default);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression, bool tracking = false, CancellationToken ct = default);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression, CancellationToken ct = default);
        Task<int> CountAsync(Expression<Func<T, bool>>? expression = null, CancellationToken ct = default);
    }
}
