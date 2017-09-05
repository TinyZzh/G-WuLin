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
        ///     ���ݻ���
        /// </summary>
        protected readonly Dictionary<TK, TB> CacheDic = new Dictionary<TK, TB>();

        /// <summary>
        ///     �Ƿ��Ѿ���ʼ��
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
        ///     ��ȡCache����
        /// </summary>
        /// <returns></returns>
        public string CacheName { get; set; }

        /// <summary>
        ///     ��ʼ������
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
        ///     ��������
        /// </summary>
        public virtual void Load()
        {
            LoadFromData();
        }

        /// <summary>
        ///     ���¼�������
        /// </summary>
        public virtual void Reload()
        {
            CacheDic.Clear();
            Init();
        }

        /// <summary>
        ///     ����ȫ������
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
        ///     ��*.data�ļ��м���������Ϣ(JSON��ʽ����)
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
        ///     ����key��ȡ��Ӧ��Bean.
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
        ///     ��ȡȫ������
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
    ///     �������
    /// </summary>
    /// <typeparam name="TK">�����Ψһ��������, ����Ϊ��ֵ����</typeparam>
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
        ///     ��ȡCache����
        /// </summary>
        /// <returns></returns>
        string CacheName { get; set; }

        /// <summary>
        ///     ��ʼ������
        /// </summary>
        void Init();

        /// <summary>
        ///     ��������
        /// </summary>
        void Load();

        /// <summary>
        ///     ���¼�������
        /// </summary>
        void Reload();

        /// <summary>
        ///     ����ȫ������
        /// </summary>
        void Dispose();
    }
}