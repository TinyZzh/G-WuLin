using System.Collections.Generic;
using Assets.Scripts.Game.Bean;

namespace Assets.Scripts.Game.Cache
{
    internal class CfgItem : CacheObject<int>
    {
        /// <summary>
        ///     �������ñ�ID
        /// </summary>
        public int CfgItemId { get; set; }

        /// <summary>
        ///     ��������
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     ��������
        /// </summary>
        public ItemType Type { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }

        /// <summary>
        ///     ����۸�
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        ///     ���ۼ۸�
        /// </summary>
        public int SellPrice { get; set; }

        /// <summary>
        ///     ά������
        /// </summary>
        public int Cost { get; set; }


        public int GetKey()
        {
            return CfgItemId;
        }
    }

    /// <summary>
    ///     �������û���
    /// </summary>
    internal class CfgItemCache : Cache<int, CfgItem>
    {
        private readonly Dictionary<int, CfgItem> _cfgItems = new Dictionary<int, CfgItem>();

        public override string CacheName()
        {
            return "cfg_item";
        }

        public override void Load()
        {
            _cfgItems.Add(1, new CfgItem
            {
                CfgItemId = 1
            });
        }

        /// <summary>
        ///     ��ȡ����������Ϣ
        /// </summary>
        /// <param name="cfgItemId"></param>
        /// <returns></returns>
        public CfgItem GetCfgItemById(int cfgItemId)
        {
            return _cfgItems.ContainsKey(cfgItemId) ? _cfgItems[cfgItemId] : default(CfgItem);
        }
    }
}