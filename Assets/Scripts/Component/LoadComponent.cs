using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///     加载 - 切换场景
/// </summary>
public class LoadComponent : MonoBehaviour
{
    /// <summary>
    ///     加载进度表
    /// </summary>
    private Transform _imgLoadingTransform;

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
        _imgLoadingTransform = transform.Find("ImgLoading");
    }

    public void ShowLoadPanel(Action before, int cfgSceneId, Action after)
    {
        if (before != null)
            before.Invoke();
        StartCoroutine(ShowLoading(after));
    }

    private IEnumerator ShowLoading(Action after)
    {
        if (_imgLoadingTransform == null)
            yield break;
        var coImage = _imgLoadingTransform.GetComponent<Image>();
        if (coImage == null)
            yield break;
        coImage.fillAmount = 0.0f;
        while (true)
        {
            coImage.fillAmount += 0.005f;
            yield return 1;
            if (coImage.fillAmount >= 1.0f)
            {
                DestroyObject(transform.gameObject);
                if (after != null)
                    after.Invoke();
                yield break;
            }
        }
    }
}