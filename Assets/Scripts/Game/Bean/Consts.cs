namespace Assets.Scripts.Game.Bean
{
    /// <summary>
    ///     物品类型
    /// </summary>
    internal enum ItemType
    {
        /// <summary>
        ///     普通物品
        /// </summary>
        Normal,

        /// <summary>
        ///     武器
        /// </summary>
        Gun = 1,

        /// <summary>
        ///     装甲
        /// </summary>
        Armor,

        /// <summary>
        ///     炸弹
        /// </summary>
        Boom,

        /// <summary>
        ///     战车
        /// </summary>
        Tank
    }

    /// <summary>
    ///     属性点枚举
    /// </summary>
    internal enum PropertyType
    {
        None,

        /// <summary>
        ///     攻击
        /// </summary>
        Attack = 1,

        /// <summary>
        ///     防御
        /// </summary>
        Defense,

        /// <summary>
        ///     能量. 1技能点 = 10能量
        /// </summary>
        Energy,

        /// <summary>
        ///     耐力. 2技能点=1耐力
        /// </summary>
        Stamina
    }

    /// <summary>
    ///     地图格子类型
    /// </summary>
    public enum TiledType
    {
        Normal,
        Wall,
        Door,

        /// <summary>
        ///     NPC
        /// </summary>
        Npc
    }
}