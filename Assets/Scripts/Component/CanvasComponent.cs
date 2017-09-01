using System;
using System.Collections;
using System.IO;
using Assets.Scripts.Game;
using Assets.Scripts.Game.Plugin;
using UnityEngine;

/// <summary>
///     Canvas
/// </summary>
public class CanvasComponent : MonoBehaviour
{
    /// <summary>
    ///     加载面板
    /// </summary>
    private Transform _loadPanel;

    private void Awake()
    {
        Mafia.Instance.Init();
        var plugin = Mafia.Instance.GetPlugin<MafiaPlugin>();


        Debug.Log("Plugin is " + plugin);
        //        GetLoadProfab();


        ShowLoadPanel();

//        _loadPanel = transform.Find("LoadPanel");
//        _loadPanel.gameObject.SetActive(true);
//        var loadComponent = _loadPanel.GetComponent<LoadComponent>();
//        if (loadComponent != null)
//            loadComponent.ShowLoadPanel(() => { Debug.Log("before load"); }, 100,
//                () => { ShowAlert(0, 0, 300, 200, "Hello World!"); });
    }

    // Update is called once per frame
    private void Update()
    {
    }

    #region 菜单界面

    public void GetLoadProfab()
    {
        var load = Resources.Load("Prefab/PfbLoadPanel");
        var obj = (GameObject) Instantiate(load);
        var canvas = GameObject.Find("Canvas");
        if (canvas != null)
        {
            obj.transform.parent = canvas.transform;

            var rectTransform = obj.transform as RectTransform;
            if (rectTransform != null)
                rectTransform.offsetMax = new Vector2(0, 0);

            Debug.Log("obj.transform.parent = canvas.transform;");
        }
    }


    public void ShowLoadPanel()
    {
        //        AssetBundle.LoadAsync()

        StartCoroutine(LoadAsyncCoroutine("ui.normal", "PfbLoadPanel", prefab =>
        {
            var instance = Instantiate(prefab);
            instance.gameObject.SetActive(true);
            instance.transform.parent = transform;
            var rectTransform = instance.transform as RectTransform;
            if (rectTransform != null)
            {
                rectTransform.anchorMin = Vector2.zero;
                rectTransform.anchorMax = Vector2.one;
                //
                rectTransform.offsetMin = Vector2.zero;
                rectTransform.offsetMax = Vector2.zero;

            }
            var loadComponent = instance.GetComponent<LoadComponent>();
            if (loadComponent != null)
                loadComponent.ShowLoadPanel(() => { Debug.Log("before load"); }, 100,
                    () => { ShowAlert(0, 0, 300, 200, "Hello World!"); });
        }));

//        var resourceRequest = Resources.LoadAsync("");
//        resourceRequest.
    }

    private IEnumerator LoadAsyncAssetBundleCoroutine(string path, Action<AssetBundle> callback)
    {
        var request = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, path));
        yield return request;
        callback(request.assetBundle);
    }

    private IEnumerator LoadAsyncCoroutine(string path, string resName, Action<GameObject> callback)
    {
        var request = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, path));
        yield return request;
        var assetBundle = request.assetBundle;
        if (assetBundle == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            yield break;
        }
        var assetLoadRequest = assetBundle.LoadAssetAsync<GameObject>(resName);
        yield return assetLoadRequest;
        callback(assetLoadRequest.asset as GameObject);
    }

    public void LoadAssetbundleAsync(string path, Action<AssetBundle> callback)
    {
        StartCoroutine(LoadAsyncAssetBundleCoroutine(path, callback));
    }


    private IEnumerator LoadAsyncCoroutine2(string bundlePath, string resName, Action<AssetBundle> callback)
    {
        var bundleLoadRequest =
            AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, "myassetBundle"));
        yield return bundleLoadRequest;

        var myLoadedAssetBundle = bundleLoadRequest.assetBundle;
        if (myLoadedAssetBundle == null)
        {
            Debug.Log("Failed to load AssetBundle!");
            yield break;
        }
        var assetLoadRequest = myLoadedAssetBundle.LoadAssetAsync<GameObject>(resName);
        yield return assetLoadRequest;

        var prefab = assetLoadRequest.asset as GameObject;
        Instantiate(prefab);

        myLoadedAssetBundle.Unload(false);
    }


    public void ShowAlert(float x, float y, float width, float height, string content)
    {
        var load = Resources.Load("Panel/PromptPanel");
        if (load != null)
        {
            var obj = (GameObject) Instantiate(load);
            obj.transform.parent = transform;
            var rect = obj.transform as RectTransform;
            if (rect != null)
                rect.rect.Set(x, y, width, height);
            var promptCo = obj.GetComponent<PromptComponent>();
            if (promptCo != null)
                promptCo.ShowAlert(content);
        }
        Debug.Log("obj.transform.parent = canvas.transform;");
    }

    #endregion
}