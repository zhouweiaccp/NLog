using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace NLog.Internal
{
    class Cache
    {
        private MemoryCache _cache;
        private CacheItemPolicy _policy;

        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public Cache(string name)
        {
            _cache = new MemoryCache(name);
            _policy = new CacheItemPolicy();

        }

        /// <summary>Inserts a cache entry into the cache using the specified key and value and the specified details for how it is to be evicted.</summary>
        /// <returns>If a matching cache entry already exists, a cache entry; otherwise, null.</returns>
        /// <param name="key">A unique identifier for the cache entry to add or get. </param>
        /// <param name="value">The data for the cache entry.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="key" /> is null.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="value" /> is null.</exception>
        /// <exception cref="T:System.ArgumentException">Both the absolute and sliding expiration values of <see cref="T:System.Runtime.Caching.CacheItemPolicy" /> object are set to values other than the defaults of <see cref="F:System.Runtime.Caching.ObjectCache.InfiniteAbsoluteExpiration" /> and <see cref="F:System.Runtime.Caching.ObjectCache.NoSlidingExpiration" />. The <see cref="T:System.Runtime.Caching.MemoryCache" /> class cannot set expiration policy based on a combination of both an absolute and a sliding expiration. Only one expiration setting can be explicitly set when you use the <see cref="T:System.Runtime.Caching.MemoryCache" /> class. The other setting must be set to <see cref="F:System.Runtime.Caching.ObjectCache.InfiniteAbsoluteExpiration" /> or <see cref="F:System.Runtime.Caching.ObjectCache.NoSlidingExpiration" />.-or-Both the removal callback and the update callback have been specified for <see cref="T:System.Runtime.Caching.CacheItemPolicy" />. The <see cref="T:System.Runtime.Caching.MemoryCache" /> only supports using one type of callback per cache entry.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The <see cref="P:System.Runtime.Caching.CacheItemPolicy.SlidingExpiration" /> property is set to a value less than <see cref="F:System.TimeSpan.Zero" />.-or-The <see cref="P:System.Runtime.Caching.CacheItemPolicy.SlidingExpiration" /> has been set to a value greater than one year.-or-The <see cref="P:System.Runtime.Caching.CacheItemPolicy.Priority" /> property is not a value of the <see cref="T:System.Runtime.Caching.CacheItemPriority" /> enumeration.</exception>
        public object AddOrGetExisting(string key, object value)
        {

            
            return _cache.AddOrGetExisting(key, value, _policy);
        }
    }
}
