using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //Task<List<Villa>> GetAllAsync(Expression<Func<Villa, bool>> filter = null);
        //Task<Villa> GetAsync(Expression<Func<Villa, bool>> filter = null, bool tracked = true);
        //Task CreateAsync(Villa entity);
        //Task UpdateAsync(Villa entity);
        //Task RemoveAsync(Villa entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, int pageSize = 0, int pageNumber = 1);
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, string? includeProperties = null);
        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveAsync();
    }
}
