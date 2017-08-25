using System;
using Assets.Scripts.Game.Bean;
using UnityEngine;

public class UnitComponent : MonoBehaviour
{
    public int Id { get; set; }
    public string Name { get; set; }
    public UnitType Type { get; set; }
    public string Avator { get; set; }


    /// <summary>
    ///     位置
    /// </summary>
    public Vector3 Point;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    #region Properties

    public UnitProperty Val { get; set; }
    public UnitProperty Percent { get; set; }


    public void Init(int id, string name, string avator, UnitProperty val, UnitProperty percent)
    {
        Id = id;
        Name = name;
        Avator = avator;
        Val = val;
        Percent = percent;
    }

    /// <summary>
    ///     单位总HP
    /// </summary>
    public float Hp
    {
        get { return Math.Min(Val.Hp * Percent.Hp, MaxHp); }
    }

    /// <summary>
    ///     单位总HP上限
    /// </summary>
    public float MaxHp
    {
        get { return Val.MaxHp * Percent.MaxHp; }
    }

    /// <summary>
    ///     单位总MP
    /// </summary>
    public float Mp
    {
        get { return Math.Min(Val.Mp * Percent.Mp, MaxMp); }
    }

    /// <summary>
    ///     单位总MP上限
    /// </summary>
    public float MaxMp
    {
        get { return Val.MaxMp * Percent.MaxMp; }
    }

    /// <summary>
    ///     单位总行动力
    /// </summary>
    public float Energy
    {
        get { return Val.Energy * Percent.Energy; }
    }

    /// <summary>
    ///     单位总攻击力
    /// </summary>
    public float Attack
    {
        get { return Val.Attack * Percent.Attack; }
    }

    /// <summary>
    ///     单位总防御力
    /// </summary>
    public float Defence
    {
        get { return Val.Defence * Percent.Defence; }
    }

    #endregion
}