using System;
using System.Threading.Tasks;

namespace RevStack.Cache
{
    public interface ICacheService
    {
        TEntity Get<TEntity>(string key);
        void Set<TEntity>(string key, TEntity entity);
        void Remove(string key);
        void Clear();
        Task<TEntity> GetAsync<TEntity>(string key);
        Task SetAsync<TEntity>(string key, TEntity entity);
        Task RemoveAsync(string key);
        Task ClearAsync();
    }
}
