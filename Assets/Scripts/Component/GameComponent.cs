﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Assets.Scripts.Game;
using Assets.Scripts.Game.Cache;
using Assets.Scripts.Game.Plugin;
using Assets.Scripts.Game.Utils;
using Google.Protobuf;
using Org.OkraAx.V3;
using UnityEngine;

public class GameComponent : MonoBehaviour
{


    public CfgBuild CfgBuild;

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



        var bean = new CfgBuild();
        bean.Type = 1;
        bean.CfgBuildId = 2;
        var json = JsonUtility.ToJson(bean);
        Debug.Log(json);
        var fromJson = JsonUtility.FromJson<CfgBuild>(json);
        Debug.Log(fromJson);

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


    public void LoadAssetbundleAsync(string path, Action<AssetBundle> callback)
    {
        StartCoroutine(Mafia.AsyncLoadAssetBundle(path, callback));
    }


}