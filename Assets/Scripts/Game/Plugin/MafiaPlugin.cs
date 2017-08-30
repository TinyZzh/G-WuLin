using System;
using System.Collections.Generic;
using Assets.Scripts.Game.Bean;
using Assets.Scripts.Game.Cache;
using Assets.Scripts.Game.Core;
using Assets.Scripts.Game.Net;
using Google.Protobuf;
using Org.OkraAx.V3;
using UnityEngine;

namespace Assets.Scripts.Game.Plugin
{
    /// <summary>
    ///     游戏核心组件
    /// </summary>
    internal class MafiaPlugin : ComplexNetPlugin
    {
        public override void InitPlugin()
        {
            RegisterMethod(Api.CallbackLogin, typeof(RetBean), CallbackLogin);
            RegisterMethod(Api.CallbackSyncTime, typeof(RetBean), CallbackSyncTime);
        }

        #region 玩家属性

        /// <summary>
        ///     角色信息
        /// </summary>
        public RoleData RoleInfo { get; set; }


        public readonly Dictionary<int, ItemInfo> Items = new Dictionary<int, ItemInfo>();

        /// <summary>
        ///     道具信息
        /// </summary>
        public readonly Dictionary<ItemType, List<ItemInfo>> ItemInfo = new Dictionary<ItemType, List<ItemInfo>>();


        public MafiaMemberInfo Members { get; set; }


        public void InitMafiaMember()
        {
            var memberCount = 100;
            CalcMemberProperty(memberCount, true);
            CalcMemberProperty(memberCount, false);
        }

        public int CalcMemberProperty(int amount, bool isAtk)
        {
            ItemType[] types = {ItemType.Gun, ItemType.Armor, ItemType.Boom, ItemType.Tank};
            var totalVal = 0;
            foreach (var itemType in types)
            {
                var totalItemUsed = 0;
                foreach (var itemInfo in ItemInfo[itemType])
                {
                    if (totalItemUsed >= amount)
                        break;
                    var used = Math.Min(amount - totalItemUsed, itemInfo.Amount);
                    var cfgItem = Mafia.Instance.CacheStore.GetById<int, CfgItem>(itemInfo.CfgItemId);
                    if (cfgItem != null)
                    {
                        totalItemUsed += used;
                        totalVal += used * (isAtk ? cfgItem.Attack : cfgItem.Defence);
                    }
                }
            }
            return totalVal;
        }


        /// <summary>
        ///     总收入
        /// </summary>
        public long TotalIncome { get; set; }

        /// <summary>
        ///     总维护费
        /// </summary>
        public long TotalCost { get; set; }

        #endregion

        #region 方法

        public void FetchMoney(int money)
        {
            RoleInfo.Money += money;
        }

        public bool UseMoney(int money)
        {
            if (money > 0 && RoleInfo.Money > money)
                RoleInfo.Money -= money;
            return false;
        }


        public void FetchExp(int exp)
        {
            if (exp <= 0) return;
            RoleInfo.Exp += exp;
            while (true)
            {
                var cfgLevel = Mafia.Instance.CacheStore.GetById<int, CfgLevel>(RoleInfo.Level + 1);
                if (cfgLevel != null && RoleInfo.Exp >= cfgLevel.Exp)
                {
                    RoleInfo.Level++;
                    RoleInfo.Exp -= cfgLevel.Exp;
                }
                else
                {
                    break;
                }
            }
        }

        public void UseSkillPoint(PropertyType type, int point)
        {
            if (point <= 0)
                return;
            if (RoleInfo.SkillPointBean.SkillPoints < point)
                return;

            switch (type)
            {
                case PropertyType.None:
                    //  TODO: 参数错误
                    return;
                case PropertyType.Attack:
                    RoleInfo.SkillPointBean.Attack += point;
                    break;
                case PropertyType.Defense:
                    RoleInfo.SkillPointBean.Defense += point;
                    break;
                case PropertyType.Energy:
                    RoleInfo.SkillPointBean.Energy += point * 10;
                    break;
                case PropertyType.Stamina:
                    RoleInfo.SkillPointBean.Stamina += point / 2.0f;
                    break;
            }
            RoleInfo.SkillPointBean.SkillPoints -= point;
        }


        /// <summary>
        ///     初始化物品
        /// </summary>
        public void InitItem()
        {
            foreach (var itemData in Items.Values)
            {
                var cfgItem = Mafia.Instance.CacheStore.GetById<int, CfgItem>(itemData.CfgItemId);
                if (cfgItem == null)
                {
                    Items.Remove(itemData.CfgItemId);
                    continue;
                }
                TotalCost += cfgItem.Cost * itemData.Amount;
            }
        }


        public void BuyItem(int cfgItemId, int amount)
        {
            if (amount <= 0 || amount > 10000) return;
            var cfgItem = Mafia.Instance.CacheStore.GetById<int, CfgItem>(cfgItemId);
            if (cfgItem == null)
                return;
            if (UseMoney(cfgItem.Price * amount))
            {
                if (Items.ContainsKey(cfgItemId))
                    Items[cfgItemId].Amount = amount;
                else
                    Items.Add(cfgItemId, new ItemInfo
                    {
                        CfgItemId = cfgItemId,
                        Amount = amount
                    });
                TotalCost += cfgItem.Cost * amount;
            }
        }

        public void SellItem(int cfgItemId, int amount)
        {
            if (amount <= 0 || amount > 10000) return;
            var cfgItem = Mafia.Instance.CacheStore.GetById<int, CfgItem>(cfgItemId);
            if (cfgItem == null)
                return;
            if (cfgItem.SellPrice <= 0)
                return;
            if (!Items.ContainsKey(cfgItemId) || Items[cfgItemId].Amount < amount)
                return;
            if (Items[cfgItemId].Amount <= 0)
            {
                // 物品不存在
                Items.Remove(cfgItemId);
                return;
            }
            Items[cfgItemId].Amount -= amount;
            FetchMoney(cfgItem.Price * amount);
            TotalCost -= cfgItem.Cost * amount;
        }

        #endregion

        #region 接口

        public void OnLogin(string openId)
        {
            PushEvent(Api.ApiOnLogin, new LoginBean
            {
                OpenId = openId
            });
        }

        public void OnSyncTime()
        {
            PushEvent(Api.ApiOnSyncTime, new GpcVoid());
        }

        #endregion

        #region 回调函数

        [GpcCallback]
        private void CallbackSyncTime(IMessage obj)
        {
            Debug.Log("[CallbackSyncTime]");
        }

        [GpcCallback]
        public void CallbackLogin(IMessage msg)
        {
            Debug.Log("[CallbackLogin]");
            //  登录失败  - 创建橘色

            //  登录成功    -   同步系统时间

            OnSyncTime();
        }

        #endregion
    }
}