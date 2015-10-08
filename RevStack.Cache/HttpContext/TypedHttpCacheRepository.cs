using System;
using System.Collections;

namespace RevStack.Cache
{
    public class TypedHttpCacheRepository<TEntity> : HttpCacheRepository, ITypedCacheRepository<TEntity> where TEntity : class
    {
        public override void Clear()
        {
            var cache = _context.Cache;
            foreach (DictionaryEntry e in cache)
            {
                string key = e.Key.ToString();
                if (cache[key].GetType()==typeof(TEntity))
                {
                    cache.Remove(key);
                }
            }
        }
    }
}
