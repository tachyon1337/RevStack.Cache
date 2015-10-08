using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevStack.Cache
{
    public interface ITypedCacheRepository<TEntity> : ICacheRepository where TEntity: class { }
}
