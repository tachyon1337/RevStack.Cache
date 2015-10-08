using System;

namespace RevStack.Cache
{
    public class CacheEntity<TEntity> where TEntity : class
    {
        public string Key { get; set; }
        TEntity Entity { get; set; }
    }
}
