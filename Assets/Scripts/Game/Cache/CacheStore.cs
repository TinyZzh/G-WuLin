using System;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Cache
{
    /// <summary>
    /// 缓存
    /// </summary>
    internal class CacheStore
    {
        private readonly Dictionary<Type, ICache> _caches = new Dictionary<Type, ICache>();

        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            _caches.Add(typeof(CfgBuildCache), new CfgBuildCache());
            foreach (var cache in _caches)
            {
                cache.Value.Init();
            }
        }

        public ICache GetCache<TC>()
            where TC : ICache
        {
            var type = typeof(TC);
            return _caches.ContainsKey(type) ? _caches[type] : default(TC);
        }

        public Cache<TK, TB> GetCache<TK, TB>()
            where TK : struct
            where TB : class, CacheObject<TK>
        {
            var type = typeof(Cache<TK, TB>);
            return _caches.ContainsKey(type) ? _caches[type] as Cache<TK, TB> : default(Cache<TK, TB>);
        }

        public TB GetById<TK, TB>(TK key)
            where TK : struct
            where TB : class, CacheObject<TK>
        {
            var type = typeof(Cache<TK, TB>);
            return _caches.ContainsKey(type) && _caches[type] is Cache<TK, TB>
                ? ((Cache<TK, TB>) _caches[type]).GetByKey(key)
                : default(TB);
        }

        public List<TB> GetByAll<TK, TB>()
            where TK : struct
            where TB : class, CacheObject<TK>
        {
            var type = typeof(Cache<TK, TB>);
            return _caches.ContainsKey(type) && _caches[type] is Cache<TK, TB>
                ? ((Cache<TK, TB>) _caches[type]).GetAll()
                : default(List<TB>);
        }
    }
}