using System;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace RevStack.Cache
{
    public class TypedMemoryCacheRepository<TEntity> : MemoryCacheRepository, ITypedCacheRepository<TEntity> where TEntity : class
    {
        public override void Clear()
        {
            foreach (var e in _context)
            {
                string key = e.Key.ToString();
                if (_context[key].GetType() == typeof(TEntity))
                {
                    _context.Remove(key);
                }
            }
        }
    }
}
