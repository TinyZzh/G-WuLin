namespace Assets.Scripts.Game.Bean
{
    /// <summary>
    ///     角色技能点信息
    /// </summary>
    public class RoleSkillPointBean
    {
        public int SkillPoints { get; set; }
        public float Attack { get; set; }
        public float Defense { get; set; }
        public float Energy { get; set; }
        public float Stamina { get; set; }
    }

    /// <summary>
    ///     角色属性
    /// </summary>
    public class RoleData
    {
        /// <summary>
        ///     角色唯一ID
        /// </summary>
        public long Uid { get; set; }

        /// <summary>
        ///     角色名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     钱
        /// </summary>
        public long Money { get; set; }

        /// <summary>
        ///     角色当前等级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        ///     角色当前经验值
        /// </summary>
        public int Exp { get; set; }

        /// <summary>
        ///     上一次收获时间
        /// </summary>
        public long LastFetchMoney { get; set; }

        /// <summary>
        ///     技能点信息
        /// </summary>
        public RoleSkillPointBean SkillPointBean { get; set; }

        /// <summary>
        ///     帮派成员数量
        /// </summary>
        public int MafiaMemberCount { get; set; }
    }

    /// <summary>
    ///     物品信息
    /// </summary>
    internal class ItemInfo
    {
        /// <summary>
        ///     物品数量
        /// </summary>
        public int Amount;

        /// <summary>
        ///     物品配置表ID
        /// </summary>
        public int CfgItemId;

        /// <summary>
        ///     物品唯一ID
        /// </summary>
        public long ItemId;
    }
}