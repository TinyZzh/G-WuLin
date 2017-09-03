using Assets.Scripts.Game.Bean;

namespace Assets.Scripts.Game.Cache
{
    internal class CfgItem : ICacheObject<int>
    {
        public int Attack;

        /// <summary>
        ///     道具配置表ID
        /// </summary>
        public int CfgItemId;

        /// <summary>
        ///     维护费用
        /// </summary>
        public int Cost;

        public int Defence;

        /// <summary>
        ///     道具名称
        /// </summary>
        public string Name;

        /// <summary>
        ///     购买价格
        /// </summary>
        public int Price;

        /// <summary>
        ///     出售价格
        /// </summary>
        public int SellPrice;

        /// <summary>
        ///     道具类型
        /// </summary>
        public ItemType Type;


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
        public CfgItemCache() : base("cfg_item")
        {
        }
    }
}