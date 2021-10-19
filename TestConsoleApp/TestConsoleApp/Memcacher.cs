using System.Collections;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace TestConsoleApp
{
    class MemoryCacher : MemoryCache
    {
       // protected readonly MemoryCache _memoryCache;
        public MemoryCacher() : base("JobCacher")
        {
          //  _memoryCache = MemoryCache.Default;
        }


        public T Get<T>(string key) where T : class
        {
            if (!base.Contains(key))
            {
                return default(T);
            }

            return (T)base.Get(key);
        }

        public bool Add<T>(string key, T value)
        {
            CacheItemPolicy policy = new CacheItemPolicy();
            if (!base.Contains(key))
            {
                return base.Add(key, value, policy);
            }

            return false;
        }

        public bool Update<T>(string key, T value)
        {
            if (base.Contains(key))
            {
                base.Remove(key);
            }

            return this.Add(key, value);
        }


        public IEnumerator<KeyValuePair<string, object>> GetAllCachedItems()
        {
            IEnumerator<KeyValuePair<string, object>> a = base.GetEnumerator();
            return a;
        }
    }
}
