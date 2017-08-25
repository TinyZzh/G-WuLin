using System;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Cache
{
    internal abstract class Cache<TK, TB> : ICache
        where TK : struct
        where TB : class, CacheObject<TK>
    {
        /// <summary>
        ///     数据缓存
        /// </summary>
        protected readonly Dictionary<TK, TB> CacheDic = new Dictionary<TK, TB>();

        /// <summary>
        ///     是否已经初始化
        /// </summary>
        protected bool IsInitialized;

        /// <summary>
        ///     获取Cache名称
        /// </summary>
        /// <returns></returns>
        public abstract string CacheName();

        /// <summary>
        ///     初始化缓存
        /// </summary>
        public void Init()
        {
            try
            {
                Load();
                IsInitialized = true;
            }
            catch (Exception e)
            {
                //  TODO: 实现日志输出和记录
            }
        }

        /// <summary>
        ///     加载数据
        /// </summary>
        public abstract void Load();

        /// <summary>
        ///     重新加载数据
        /// </summary>
        public void Reload()
        {
            CacheDic.Clear();
            Init();
        }

        /// <summary>
        ///     销毁全部缓存
        /// </summary>
        public virtual void Dispose()
        {
            lock (this)
            {
                IsInitialized = false;
                CacheDic.Clear();
            }
        }

        /// <summary>
        ///     根据key获取对应的Bean.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public TB GetByKey(TK key)
        {
            var bean = default(TB);
            CacheDic.TryGetValue(key, out bean);
            return bean;
        }

        /// <summary>
        ///     获取全部缓存
        /// </summary>
        /// <returns></returns>
        public List<TB> GetAll()
        {
            var list = new List<TB>();
            foreach (var key in CacheDic.Keys)
                list.Add(CacheDic[key]);
            return list;
        }
    }

    /// <summary>
    ///     缓存对象
    /// </summary>
    /// <typeparam name="TK">对象的唯一主键类型, 限制为是值类型</typeparam>
    internal interface CacheObject<TK> where TK : struct
    {
        TK GetKey();
    }

    internal interface ICache
    {
        /// <summary>
        ///     获取Cache名称
        /// </summary>
        /// <returns></returns>
        string CacheName();

        /// <summary>
        ///     初始化缓存
        /// </summary>
        void Init();

        /// <summary>
        ///     加载数据
        /// </summary>
        void Load();

        /// <summary>
        ///     重新加载数据
        /// </summary>
        void Reload();

        /// <summary>
        ///     销毁全部缓存
        /// </summary>
        void Dispose();
    }
}