using System;

using System.Threading.Tasks;

namespace RevStack.Cache
{
    public class CacheService : ICacheService
    {
        protected ICacheRepository _repository;
        public CacheService(ICacheRepository repository)
        {
            _repository = repository;
        }
        public void Clear()
        {
            _repository.Clear();
        }

        public Task ClearAsync()
        {
            Clear();
            return Task.FromResult(true);
        }

        public TEntity Get<TEntity>(string key)
        {
            return _repository.Get<TEntity>(key);
        }

        public Task<TEntity> GetAsync<TEntity>(string key)
        {
            return Task.FromResult(Get<TEntity>(key));
        }

        public void Set<TEntity>(string key, TEntity entity)
        {
            _repository.Set(key, entity);
        }

        public Task SetAsync<TEntity>(string key, TEntity entity)
        {
            Set(key, entity);
            return Task.FromResult(true);
        }

        public void Remove(string key)
        {
            _repository.Remove(key);
        }

        public Task RemoveAsync(string key)
        {
            Remove(key);
            return Task.FromResult(true);
        }
    }



}
