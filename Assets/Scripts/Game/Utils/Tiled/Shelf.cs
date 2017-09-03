﻿namespace Assets.Scripts.Game.Utils.Tiled
{
    /// <summary>
    ///     货架
    /// </summary>
    public class Shelf : Furnish
    {
        public int CfgFurnishId;

        public int Sell;

        public int Id
        {
            get { return CfgFurnishId; }
            set { CfgFurnishId = value; }
        }

        public Grid[,] Occupy { get; set; }
    }
}