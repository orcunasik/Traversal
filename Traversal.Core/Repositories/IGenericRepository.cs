using System.Linq.Expressions;
using Traversal.Core.Models.Abstract;

namespace Traversal.Core.Repositories
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAll();
        Task AddAsync(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
