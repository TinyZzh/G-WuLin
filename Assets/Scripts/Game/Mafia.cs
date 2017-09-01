using System;
using System.Collections.Generic;
using Assets.Scripts.Game.Cache;
using Assets.Scripts.Game.Core;
using Assets.Scripts.Game.Plugin;
using UnityEngine;

namespace Assets.Scripts.Game
{
    /// <summary>
    /// </summary>
    internal class Mafia
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
            CacheStore.Init();
            InitPlugin();
        }

        public void InitPlugin()
        {
            CreatePlugin(typeof(MafiaPlugin));
            CreatePlugin(typeof(MafiaMemberPlugin));
            CreatePlugin(typeof(NetPlugin));
        }

        public bool IsPluginExist<T>() where T : class, IPlugin
        {
            return _plugins.ContainsKey(typeof(T));
        }

        public T GetPlugin<T>() where T : class, IPlugin
        {
            IPlugin plugin = null;
            _plugins.TryGetValue(typeof(T), out plugin);
            if (plugin == null)
                throw new Exception(string.Format("Plugin {0} undefined or unregisted.", typeof(T)));
            if (!plugin.IsInitialized())
                plugin.Initialize();
            return plugin as T;
        }

        #region 游戏日志

        public void Info(string message)
        {
            var logPlugin = GetPlugin<LogPlugin>();
            if (logPlugin != null)
            {
                logPlugin.Info(message, "");
            }
            Debug.Log(message);
        }

        #endregion


        #region IOC和依赖注入 - 初始化Plugin

        //  使用反射和注入   实现plugin实例化和依赖注入(Denpen  Inject)   简单的IOC
        /// <summary>
        ///     仅注入注解[GamePlugin]属性的字段
        /// </summary>
        /// <param name="plugin"></param>
        /// <see cref="GamePlugin" />
        public void InjectPlugin(IPlugin plugin)
        {
            var propertyInfos = plugin.GetType().GetProperties();
            foreach (var propertyInfo in propertyInfos)
            {
                var customAttributes = propertyInfo.GetCustomAttributes(typeof(GamePlugin), true);
                if (customAttributes.Length <= 0) continue;
                if (_plugins.ContainsKey(propertyInfo.PropertyType))
                    propertyInfo.SetValue(plugin, _plugins[propertyInfo.PropertyType], null);
                else
                    propertyInfo.SetValue(plugin, CreatePlugin(propertyInfo.PropertyType), null);
            }
        }

        public IPlugin CreatePlugin(Type type)
        {
            if (!typeof(IPlugin).IsAssignableFrom(type))
                throw new ArgumentException("Illegal plugin type {0}", type.ToString());
            if (_plugins.ContainsKey(type)) return _plugins[type];
            //  System.Reflection.Assembly.GetExecutingAssembly().GetName().Name
            //  typeof(Program).Assembly.GetName().Name;
            var instance = Activator.CreateInstance(type.Assembly.GetName().Name, type.FullName);
            if (instance == null) return null;
            var obj = instance.Unwrap() as IPlugin;
            if (obj == null) return null;
            _plugins.Add(obj.GetType(), obj);
            InjectPlugin(obj);
            return obj;
        }

        #endregion
    }
}