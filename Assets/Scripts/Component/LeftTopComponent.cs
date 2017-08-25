using UnityEngine;
using UnityEngine.UI;

/// <summary>
///     左上角界面UI
/// </summary>
public class LeftTopComponent : MonoBehaviour
{
    #region 方法

    private void Start()
    {
    }

    private void Awake()
    {
        _hpProgressBar = transform.Find("HpPanel").GetComponent<ProgressBarComponent>();
        _mpProgressBar = transform.Find("MpPanel").GetComponent<ProgressBarComponent>();
        _txtName = transform.Find("TxtName").GetComponent<Text>();
        _txtLevel = transform.Find("ImgLv").Find("TxtLevel").GetComponent<Text>();
        _imgHp = transform.Find("HpPanel").GetComponent<Image>();
        //
        SetName(Name);
        SetLevel(Level);
        SetHp(Hp);
        SetMaxHp(MaxHp);
        SetMp(Mp);
        SetMaxMp(MaxMp);
    }


#if UNITY_EDITOR

    private void OnValidate()
    {
        //
        SetName(Name);
        SetLevel(Level);
        SetHp(Hp);
        SetMaxHp(MaxHp);
        SetMp(Mp);
        SetMaxMp(MaxMp);
    }
#endif

    private void Update()
    {
    }

    #endregion

    #region Transform

    private ProgressBarComponent _hpProgressBar;
    private Image _imgHp;
    private ProgressBarComponent _mpProgressBar;


    private Text _txtLevel;
    private Text _txtName;

    #endregion

    #region Properties

    /// <summary>
    ///     头像
    /// </summary>
    [Tooltip("头像")] public string Avator;

    /// <summary>
    ///     当前HP值
    /// </summary>
    [Tooltip("当前HP值")] public int Hp;

    /// <summary>
    ///     角色等级
    /// </summary>
    [Tooltip("角色等级")] public int Level;

    /// <summary>
    ///     HP上限
    /// </summary>
    [Tooltip("HP上限")] public int MaxHp;

    /// <summary>
    ///     MP上限
    /// </summary>
    [Tooltip("MP上限")] public int MaxMp;

    /// <summary>
    ///     当前MP值
    /// </summary>
    [Tooltip("当前MP值")] public int Mp;

    /// <summary>
    ///     角色名
    /// </summary>
    [Tooltip("角色名")] public string Name;

    #endregion

    #region Setter

    public void SetName(string mName)
    {
        Name = mName;
        if (_txtName != null)
            _txtName.text = Name;
    }

    public void SetLevel(int level)
    {
        Level = level;
        if (_txtLevel != null)
            _txtLevel.text = level.ToString();
    }

    public void SetHp(int hp)
    {
        Hp = hp;
        if (_hpProgressBar != null)
            _hpProgressBar.SetValue(hp);
    }

    public void SetMaxHp(int maxHp)
    {
        MaxHp = maxHp;
        if (_hpProgressBar != null)
            _hpProgressBar.SetMaxValue(maxHp);
    }

    public void SetMp(int mp)
    {
        Mp = mp;
        if (_mpProgressBar != null)
            _mpProgressBar.SetValue(mp);
    }

    public void SetMaxMp(int maxMp)
    {
        MaxMp = maxMp;
        if (_mpProgressBar != null)
            _mpProgressBar.SetMaxValue(maxMp);
    }

    #endregion
}