using Assets.Scripts.Game.Bean;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Game.Plugin;
using UnityEngine;

/// <summary>
/// 角色个人面板
/// </summary>
public class ProfileComponent : MonoBehaviour
{


    public RoleData RoleBean;

    /// <summary>
    /// 唯一ID
    /// </summary>
    [Tooltip("唯一ID")]
    public long Uid;
    /// <summary>
    /// 角色名
    /// </summary>
    public string Name;
    /// <summary>
    /// 头部模型
    /// </summary>
    public int FigHead;
    /// <summary>
    /// 身体模型
    /// </summary>
    public int FigBody;
    /// <summary>
    /// 攻击
    /// </summary>
    public float Attack;
    /// <summary>
    /// 防御
    /// </summary>
    public float Defense;
    /// <summary>
    /// 能量
    /// </summary>
    public float Energy;
    /// <summary>
    /// HP
    /// </summary>
    public float HP;
    /// <summary>
    /// HP上限
    /// </summary>
    public float MaxHP;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
