using System;

namespace Assets.Scripts.Game.Core
{
    /// <summary>
    ///     游戏插件. 用于实现注入方式解耦插件间的依赖关系.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
    public class GamePlugin : Attribute
    {
        public Type Type { get; set; }
    }
}