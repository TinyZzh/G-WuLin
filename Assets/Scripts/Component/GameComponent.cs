using System;
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

        ShowAlert();
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



    #region 菜单界面


    public void Main()
    {
        //  初始化场景

        //  初始化UI

        //  初始化玩家数据


    }


    public void ShowAlert()
    {
        var load = Resources.Load("Panel/PromptPanel");
        var obj = (GameObject)Instantiate(load);
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

            var promptComponent = obj.GetComponent<PromptComponent>();
            promptComponent.ShowAlert("Alert: Hello World!");


            Debug.Log("obj.transform.parent = canvas.transform;");
        }
    }

    #endregion



}