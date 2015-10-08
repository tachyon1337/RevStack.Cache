using System;

namespace RevStack.Cache
{
    public interface ICacheRepository
    {
        TEntity Get<TEntity>(string key);
        void Set<TEntity>(string key, TEntity entity);
        void Remove(string key);
        void Clear();
        double ExpirationHours { get; set; }
    }
}
