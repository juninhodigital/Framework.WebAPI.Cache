using System.Runtime.Caching;

namespace Framework.WebAPI.Cache
{
    /// <summary>
    ///  Represents an object cache and provides the base methods and properties for accessing the object cache.
    /// </summary>
    public static class CacheEngine
    {
        #region| Methods | 
        
        /// <summary>
        /// Checks whether the cache entry already exists in the cache.
        /// </summary>
        /// <param name="key">A unique identifier for the cache entry</param>
        /// <returns>true if the cache contains a cache entry with the same key value as key; otherwise, false.</returns>
        public static bool Exists(string key) => Framework.Cache.Cache.Exists(key);

        /// <summary>
        /// inserts a cache entry into the cache
        /// </summary>
        /// <param name="key">A unique identifier for the cache entry.</param>
        /// <param name="value">The object to insert</param>
        /// <param name="minutes">AbsoluteExpiration in minutes. Default one minute</param>    
        public static void Add(string key, object value, double minutes = 1) => Framework.Cache.Cache.Add(key, value, minutes);


        /// <summary>
        /// inserts a cache entry into the cache
        /// </summary>
        /// <param name="key">A unique identifier for the cache entry.</param>
        /// <param name="value">The object to insert</param>
        /// <param name="policy">CacheItemPolicy</param>
        public static void Add(string key, object value, CacheItemPolicy policy) => Framework.Cache.Cache.Add(key, value, policy);

        /// <summary>
        /// Gets an entry from the System.Runtime.Caching.ObjectCache class
        /// </summary>
        /// <typeparam name="T">param type</typeparam>
        /// <param name="key">A unique identifier for the cache entry</param>
        /// <returns></returns>
        public static T Get<T>(string key) => Framework.Cache.Cache.Get<T>(key);

        /// <summary>
        /// removes the cache entry from the cache
        /// </summary>
        /// <param name="key">A unique identifier for the cache entry</param>
        public static void Remove(string key) => Framework.Cache.Cache.Remove(key);

        /// <summary>
        /// Clear all cache entries from the System.Runtime.Caching.ObjectCache
        /// </summary>
        public static void Clear() => Framework.Cache.Cache.Clear();

        #endregion
    }
}
