using Assets.Scripts.Game;
using Assets.Scripts.Game.Plugin;
using UnityEngine;

/// <summary>
///     Canvas
/// </summary>
public class CanvasComponent : MonoBehaviour
{
    private void Awake()
    {
        Mafia.Instance.Init();
        var plugin = Mafia.Instance.GetPlugin<MafiaPlugin>();


        Debug.Log("Plugin is " + plugin);
        //        GetLoadProfab();

        ShowAlert(0,0, 300, 200, "Hello World!");
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

    public void ShowAlert(float x, float y, float width, float height, string content)
    {
        var load = Resources.Load("Panel/PromptPanel");
        if (load != null)
        {
            var obj = (GameObject)Instantiate(load);
            obj.transform.parent = transform;
            var rect = obj.transform as RectTransform;
            if (rect != null)
            {
                rect.rect.Set(x,y,width,height);
            }
            var promptCo = obj.GetComponent<PromptComponent>();
            if (promptCo != null)
            {
                promptCo.ShowAlert(content);
            }
        }
        Debug.Log("obj.transform.parent = canvas.transform;");
    }

    #endregion
}