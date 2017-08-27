using System;

namespace Assets.Scripts.Game.Core
{
    /// <summary>
    ///     回调接口
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class GpcCallback : Attribute
    {
    }
}