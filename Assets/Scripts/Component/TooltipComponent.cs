using System;
using UnityEngine;
using UnityEngine.UI;

public class TooltipComponent : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void Awake()
    {
        //TODO: ICON
        if (TxtContent != null)
        {
            var text = TxtContent.GetComponent<Text>();
            text.text = Content;
        }
    }

    #region Property

    /// <summary>
    ///     关闭按钮
    /// </summary>
    [Tooltip("关闭按钮")] public Transform BtnClose;

    /// <summary>
    ///     确认按钮
    /// </summary>
    [Tooltip("确认按钮")] public Transform BtnConfirm;

    /// <summary>
    ///     内容
    /// </summary>
    [Tooltip("显示提示内容的控件")] public Transform TxtContent;

    /// <summary>
    ///     Tooltip图标
    /// </summary>
    [Tooltip("提示框ICON")] public string Icon;

    /// <summary>
    ///     Tooltip内容
    /// </summary>
    [Tooltip("提示内容")] public string Content;

    #endregion

    #region Event

    /// <summary>
    /// </summary>
    public EventHandler CloseBtnClick;

    /// <summary>
    /// </summary>
    public EventHandler ConfirmBtnClick;


    /// <summary>
    ///     点击确认按钮
    /// </summary>
    public void OnComfirmBtnClick()
    {
        if (ConfirmBtnClick != null)
            ConfirmBtnClick(this, null);
        Destroy(transform.gameObject);
    }

    /// <summary>
    ///     点击关闭按钮
    /// </summary>
    public void OnCloseBtnClick()
    {
        if (CloseBtnClick != null)
            CloseBtnClick(this, null);
        Destroy(transform.gameObject);
    }

    #endregion
}