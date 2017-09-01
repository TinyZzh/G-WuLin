using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Assets.Scripts.Game;
using Assets.Scripts.Game.Plugin;
using Assets.Scripts.Game.Utils;
using Google.Protobuf;
using Org.OkraAx.V3;
using UnityEngine;

public class GameComponent : MonoBehaviour
{
    // Use this for initialization
    private void Start1()
    {
        Debug.logger.logEnabled = true; //  关闭日志输出

        Mafia.Instance.InitPlugin();

        var plugin = Mafia.Instance.GetPlugin<MafiaPlugin>();

        Debug.Log("Plugin is " + plugin);


        //  测试pb
        var info = new LoginBean
        {
            OpenId = "1998"
        };
        Debug.Log(info);
        var m_data = info.ToByteArray();
        //  
        var tgt_bean = LoginBean.Parser.ParseFrom(m_data);
        Debug.Log(tgt_bean);

        //
        Debug.Log(GameClock.Now());
        Debug.Log(GameClock.Timestamp);
        Debug.Log(DateTime.Now);
        Debug.Log(DateTime.Now.ToFileTimeUtc());
    }


    private void Awake()
    {
        Mafia.Instance.Init();
        var plugin = Mafia.Instance.GetPlugin<MafiaPlugin>();


        Debug.Log("Plugin is " + plugin);
        //        GetLoadProfab();

    }

    public void OnClickInitBtn()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        
    }


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
            {
//                rectTransform.offsetMin = new Vector2(16, 16);
                rectTransform.offsetMax = new Vector2(0, 0);


            }

            Debug.Log("obj.transform.parent = canvas.transform;");
        }
            
    }



    #region 资源加载

    public Dictionary<string, AssetBundle> AssetBundleCache = new Dictionary<string,AssetBundle>();



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


    #endregion



}