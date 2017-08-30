namespace Assets.Scripts.Game.Net
{
    public sealed class Api
    {
        #region Api

        public const string ApiOnLogin = "onLogin"; //  登录
        public const string ApiOnSyncTime = "onSyncTime"; //  同步系统时间

        #endregion


        #region Callback

        public const string CallbackLogin = "callbackLogin";
        public const string CallbackSyncTime = "callbackSyncTime";

        #endregion
    }
}