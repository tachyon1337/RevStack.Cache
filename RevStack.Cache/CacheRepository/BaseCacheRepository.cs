using System;

namespace RevStack.Cache
{
    public class BaseCacheRepository : ICacheRepository
    {
        protected double _hours;
        protected DateTimeOffset _expirationOffset;
        protected const double EXPIRATION_HOURS = 2;
        public BaseCacheRepository()
        {
            ExpirationHours = EXPIRATION_HOURS;
        }
        public BaseCacheRepository(double hours)
        {
            ExpirationHours = hours;
        }
        public double ExpirationHours
        {
            get
            {
                return _hours;
            }

            set
            {
                _hours = value;
                _expirationOffset = DateTimeOffset.Now.AddSeconds(value);
            }
        }

        public virtual void Clear()
        {
            throw new NotImplementedException();
        }

        public virtual TEntity Get<TEntity>(string key)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public virtual void Set<TEntity>(string key, TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
