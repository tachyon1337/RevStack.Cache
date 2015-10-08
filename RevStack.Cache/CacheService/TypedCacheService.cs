using System;


namespace RevStack.Cache
{
    public class TypedCacheService<TEntity> : CacheService, ITypedCacheService<TEntity> where TEntity : class 
    {
        public TypedCacheService(ITypedCacheRepository<TEntity> repository) : base(repository) { }
    }
}
