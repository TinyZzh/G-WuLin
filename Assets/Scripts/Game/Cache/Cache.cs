using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Assets.Scripts.Game.Cache
{
    /// <summary>
    ///     Cache
    /// </summary>
    /// <typeparam name="TK"></typeparam>
    /// <typeparam name="TB"></typeparam>
    internal abstract class Cache<TK, TB> : ICache
        where TK : struct
        where TB : class, ICacheObject<TK>
    {
        /// <summary>
        ///     数据缓存
        /// </summary>
        protected readonly Dictionary<TK, TB> CacheDic = new Dictionary<TK, TB>();

        /// <summary>
        ///     是否已经初始化
        /// </summary>
        protected bool IsInitialized;

        public Cache(string cacheName)
        {
            CacheName = cacheName;
        }

        /// <summary>
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <see cref="GetByKey" />
        public TB this[TK key]
        {
            get { return GetByKey(key); }
        }

        /// <summary>
        ///     获取Cache名称
        /// </summary>
        /// <returns></returns>
        public string CacheName { get; set; }

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
                Mafia.Instance.Error("Cache {0} Init Error. Source:{1}", new object[] {CacheName, e.Source},
                    e.Message);
            }
        }

        /// <summary>
        ///     加载数据
        /// </summary>
        public virtual void Load()
        {
            LoadFromData();
        }

        /// <summary>
        ///     重新加载数据
        /// </summary>
        public virtual void Reload()
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
        ///     从*.data文件中加载配置信息(JSON格式数据)
        /// </summary>
        public virtual void LoadFromData()
        {
            var path = Path.Combine(Application.streamingAssetsPath, "data/" + CacheName + ".data");
            if (!File.Exists(path))
            {
                Mafia.Instance.Error("File {0} not exist.", new object[] {CacheName});
                return;
            }
            var lines = File.ReadAllLines(path);
            if (lines.Length <= 0)
                return;
            var trims = ",".ToCharArray();
            foreach (var line in lines)
            {
                if (line.StartsWith("[") || line.StartsWith("]"))
                    continue;
                var obj = JsonUtility.FromJson<TB>(line.TrimEnd(trims));
                CacheDic.Add(obj.GetKey(), obj);
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
    internal interface ICacheObject<TK> where TK : struct
    {
        TK GetKey();
    }


    [Serializable]
    internal class WrapList<B>
    {
        [SerializeField]
        public List<B> List { get; set; }
    }

    internal interface ICache
    {
        /// <summary>
        ///     获取Cache名称
        /// </summary>
        /// <returns></returns>
        string CacheName { get; set; }

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