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
    /// 加载进度表
    /// </summary>
    private Transform _imgLoadingTransform;

    /// <summary>
    /// 
    /// </summary>
    [Tooltip("SceneComponent")] public Transform SceneTransform;

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
        ShowLoadPanel(1, () => { Debug.Log("Show Load Panel."); });
    }

    public void ShowLoadPanel(int cfgSceneId, Action action)
    {
        if (SceneTransform != null)
        {
            var soScene = SceneTransform.GetComponent<SceneComponent>();
            if (soScene != null)
                soScene.ChangeSceneStatus();
        }
        StartCoroutine(ShowLoading(action));
    }

    private IEnumerator ShowLoading(Action action)
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
                DestroyObject(this.transform.gameObject);
                if (action != null)
                    action.Invoke();
                yield break;
            }
        }
    }
}