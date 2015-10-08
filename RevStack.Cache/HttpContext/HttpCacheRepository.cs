using System;
using System.Collections;
using System.Web;
using HttpCache = System.Web.Caching.Cache;

namespace RevStack.Cache
{
    public class HttpCacheRepository : BaseCacheRepository
    {
        
        protected HttpContextBase _context;
        public HttpCacheRepository() : base()
        {
            _hours = EXPIRATION_HOURS;
            _context = new HttpContextWrapper(HttpContext.Current);
        }
        public HttpCacheRepository(double hours) : base(hours)
        {
            _hours = hours;
            _context = new HttpContextWrapper(HttpContext.Current);
        }
        public override void Clear()
        {
            var cache = _context.Cache;
            foreach (DictionaryEntry e in cache)
            {
                cache.Remove(e.Key.ToString());
            }
        }

        public override TEntity Get<TEntity>(string key)
        {
            return (TEntity)_context.Cache[key];
        }

        public override void Remove(string key)
        {
            _context.Cache.Remove(key);
        }

        public override void Set<TEntity>(string key, TEntity entity)
        {
            _context.Cache.Insert(key, entity, null, DateTime.Now.AddHours(_hours), HttpCache.NoSlidingExpiration);
        }
    }
}
