using System;
using System.Collections.Generic;
using Assets.Scripts.Game.Cache;
using Assets.Scripts.Game.Core;
using Assets.Scripts.Game.Plugin;

namespace Assets.Scripts.Game
{
    /// <summary>
    /// </summary>
    internal partial class Mafia
    {
        /// <summary>
        ///     Mafia单例
        /// </summary>
        public static readonly Mafia Instance = new Mafia();

        /// <summary>
        ///     缓存
        /// </summary>
        private readonly CacheStore _cacheStore = new CacheStore();

        /// <summary>
        ///     插件
        /// </summary>
        private readonly Dictionary<Type, IPlugin> _plugins = new Dictionary<Type, IPlugin>();

        /// <summary>
        ///     是否已经初始化
        /// </summary>
        private bool _isInitialized;

        /// <summary>
        ///     配置缓存
        /// </summary>
        public CacheStore CacheStore
        {
            get { return _cacheStore; }
        }


        public void Init()
        {
            if (_isInitialized)
                return;
            _isInitialized = true;
            InitPlugin();
            //  
            CacheStore.Init();
        }

       
    }
}