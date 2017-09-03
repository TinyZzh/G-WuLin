using Assets.Scripts.Game.Bean;

namespace Assets.Scripts.Game.Cache
{
    internal class CfgItem : ICacheObject<int>
    {
        public int Attack;

        /// <summary>
        ///     �������ñ�ID
        /// </summary>
        public int CfgItemId;

        /// <summary>
        ///     ά������
        /// </summary>
        public int Cost;

        public int Defence;

        /// <summary>
        ///     ��������
        /// </summary>
        public string Name;

        /// <summary>
        ///     ����۸�
        /// </summary>
        public int Price;

        /// <summary>
        ///     ���ۼ۸�
        /// </summary>
        public int SellPrice;

        /// <summary>
        ///     ��������
        /// </summary>
        public ItemType Type;


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
        public CfgItemCache() : base("cfg_item")
        {
        }
    }
}