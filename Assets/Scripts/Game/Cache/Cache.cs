using System;
using System.Collections.Generic;

namespace Assets.Scripts.Game.Cache
{
    internal abstract class Cache<TK, TB> : ICache
        where TK : struct
        where TB : class, CacheObject<TK>
    {
        /// <summary>
        ///     ���ݻ���
        /// </summary>
        protected readonly Dictionary<TK, TB> CacheDic = new Dictionary<TK, TB>();

        /// <summary>
        ///     �Ƿ��Ѿ���ʼ��
        /// </summary>
        protected bool IsInitialized;

        /// <summary>
        ///     ��ȡCache����
        /// </summary>
        /// <returns></returns>
        public abstract string CacheName();

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
                //  TODO: ʵ����־����ͼ�¼
            }
        }

        /// <summary>
        ///     ��������
        /// </summary>
        public abstract void Load();

        /// <summary>
        ///     ���¼�������
        /// </summary>
        public void Reload()
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
    internal interface CacheObject<TK> where TK : struct
    {
        TK GetKey();
    }

    internal interface ICache
    {
        /// <summary>
        ///     ��ȡCache����
        /// </summary>
        /// <returns></returns>
        string CacheName();

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