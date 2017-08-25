using System.Collections.Generic;
using Assets.Scripts.Game.Bean;

namespace Assets.Scripts.Game.Cache
{
    internal class CfgItem : CacheObject<int>
    {
        /// <summary>
        ///     道具配置表ID
        /// </summary>
        public int CfgItemId { get; set; }

        /// <summary>
        ///     道具名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     道具类型
        /// </summary>
        public ItemType Type { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }

        /// <summary>
        ///     购买价格
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        ///     出售价格
        /// </summary>
        public int SellPrice { get; set; }

        /// <summary>
        ///     维护费用
        /// </summary>
        public int Cost { get; set; }


        public int GetKey()
        {
            return CfgItemId;
        }
    }

    /// <summary>
    ///     道具配置缓存
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
        ///     获取道具配置信息
        /// </summary>
        /// <param name="cfgItemId"></param>
        /// <returns></returns>
        public CfgItem GetCfgItemById(int cfgItemId)
        {
            return _cfgItems.ContainsKey(cfgItemId) ? _cfgItems[cfgItemId] : default(CfgItem);
        }
    }
}