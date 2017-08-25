using System;
using Assets.Scripts.Game.Utils;

namespace Assets.Scripts.Game.Bean
{

    public enum UnitType
    {
        Player,
        /// <summary>
        /// 小怪
        /// </summary>
        Master,
        /// <summary>
        /// Boss
        /// </summary>
        Boss
    }


    /// <summary>
    /// 
    /// </summary>
    public class UnitProperty
    {
        public float Hp { get; set; }
        public float MaxHp { get; set; }
        public float Mp { get; set; }
        public float MaxMp { get; set; }
        /// <summary>
        /// 行动力
        /// </summary>
        public float Energy { get; set; }
        /// <summary>
        ///     攻击力
        /// </summary>
        public float Attack { get; set; }

        /// <summary>
        ///     防御力
        /// </summary>
        public float Defence { get; set; }

    }

    public enum FourDirection
    {
        Top,
        Bottom,
        Left,
        Right
    }

    public class UnitConst
    {
        //  方向偏移向量
        public static readonly Point Top = new Point(0, 1);
        public static readonly Point Bottom = new Point(0, -1);
        public static readonly Point Left = new Point(-1, 0);
        public static readonly Point Right = new Point(1, 0);
    }
}