using System;
using System.Collections;
using System.Runtime.Caching;

namespace RevStack.Cache
{
    public class MemoryCacheRepository : BaseCacheRepository
    {
        protected MemoryCache _context;
        protected CacheItemPolicy _policy;
        public MemoryCacheRepository() : base()
        {
            _hours = EXPIRATION_HOURS;
            setCachePolicy();

        }
        public MemoryCacheRepository(double hours) : base(hours)
        {
            _hours = hours;
            setCachePolicy();
        }

        protected void setCachePolicy()
        {
            _context = MemoryCache.Default;
            _policy = new CacheItemPolicy();
            _policy.AbsoluteExpiration = DateTimeOffset.Now.AddHours(_hours);
        }

        public override void Clear()
        {
            foreach (var e in _context)
            {
                _context.Remove(e.Key.ToString());
            }
        }

        public override TEntity Get<TEntity>(string key)
        {
            return (TEntity)_context.Get(key);
        }

        public override void Remove(string key)
        {
            _context.Remove(key);
        }

        public override void Set<TEntity>(string key, TEntity entity)
        {
            _context.Set(key, entity, _policy);
        }
    }
}
