using System;

namespace RevStack.Cache
{
    public interface ITypedCacheService<TEntity> : ICacheService where TEntity : class { }
}
