using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarComponent : MonoBehaviour
{
    #region 方法

    public void OnRender()
    {
        _txtLeft.text = Value.ToString();
        _txtRight.text = MaxValue.ToString();
        _imgFill.fillAmount = Value * 1.0f / MaxValue;
        _imgFill.color = FillColor;
    }

    // Use this for initialization
    private void Start()
    {
    }

    private void Awake()
    {
        _imgBackground = transform.Find("Background").GetComponent<Image>();
        _imgFill = transform.Find("ImgFill").GetComponent<Image>();
        _txtLeft = transform.Find("Panel").Find("TxtLeft").GetComponent<Text>();
        _txtMidule = transform.Find("Panel").Find("TxtMidule").GetComponent<Text>();
        _txtRight = transform.Find("Panel").Find("TxtRight").GetComponent<Text>();

#if UNITY_EDITOR
        StartCoroutine(RandomSetValue());
#endif
    }

    // Update is called once per frame
    private void Update()
    {
    }

#if UNITY_EDITOR

    private IEnumerator RandomSetValue()
    {
        while (true)
        {
            SetValue(Random.Range(0, MaxValue + 1));
            yield return new WaitForSeconds(0.5f);
        }
    }
#endif

    public void SetValue(int value)
    {
        var val = Mathf.Max(0, value);
        if (val == Value)
            return;
        Value = Mathf.Min(val, MaxValue);
        OnRender();
    }

    public void SetMaxValue(int maxVal)
    {
        var val = Mathf.Max(1, maxVal);
        if (val == MaxValue)
            return;
        MaxValue = val;
        Value = Mathf.Min(val, Value);
        OnRender();
    }

    #endregion

    #region Transform

    private Image _imgBackground;
    private Image _imgFill;
    private Text _txtLeft;
    private Text _txtMidule;
    private Text _txtRight;

    #endregion

    #region 对外字段

    /// <summary>
    ///     填充进度条的颜色
    /// </summary>
    [Tooltip("填充的颜色")] public Color FillColor = Color.green;

    /// <summary>
    ///     进度值上限
    /// </summary>
    [Tooltip("值上限")] public int MaxValue = 100;

    /// <summary>
    ///     进度值
    /// </summary>
    [Tooltip("值")] public int Value = 100;

    #endregion
}