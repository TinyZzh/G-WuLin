using System;
using UnityEngine;
using UnityEngine.UI;

public class PromptComponent : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
        Debug.Log("PromptComponent Start");
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void Awake()
    {
        Debug.Log("PromptComponent Awake");
        //TODO: ICON
        _goBtnClose = transform.Find("BtnClose");
        _goBtnConfirm = transform.Find("BtnConfirm");
        _txtContent = transform.Find("TxtContent").GetComponent<Text>();
    }

    #region Property

    /// <summary>
    ///     关闭按钮
    /// </summary>
    private Transform _goBtnClose;

    /// <summary>
    ///     确认按钮
    /// </summary>
    private Transform _goBtnConfirm;

    /// <summary>
    ///     内容
    /// </summary>
    private Text _txtContent;

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

    /// <summary>
    /// 显示警告框
    /// </summary>
    public void ShowAlert(string content)
    {
        _txtContent.text = content;
    }

    /// <summary>
    /// 显示确认框
    /// </summary>
    public void ShowConfirm(string content)
    {
        _txtContent.text = content;
    }

    public void ShowPrompt(string content)
    {
        _txtContent.text = content;
    }

    #endregion
}