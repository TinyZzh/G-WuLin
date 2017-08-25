using System;
using System.Collections;
using Assets.Scripts.Game.Bean;
using Assets.Scripts.Game.Utils;
using UnityEngine;
using Random = UnityEngine.Random;

public class SceneComponent : MonoBehaviour
{
    /// <summary>
    ///     场景信息
    /// </summary>
    public SceneGrid[,] Grids = new SceneGrid[10, 10];

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void FixedUpdate()
    {
    }

    public void Awake()
    {
        Grids = CreateTiledScene(1);
        //
        StartCoroutine(OnAiAction());
    }

    /// <summary>
    ///     更新场景
    /// </summary>
    private IEnumerator ChangeScene()
    {
        yield return 1;
    }

    private IEnumerator OnAiAction()
    {
        while (true)
        {
            var layout = GameObject.Find("UnitLayout");
            if (layout != null)
            {
                var units = layout.GetComponentsInChildren<UnitComponent>();
                if (units != null)
                    //  TODO: 查找并向距离的最近目标移动 - 或攻击
                    foreach (var component in units)
                        try
                        {
                            OnMove(component, (FourDirection) Random.Range(0, 4));
                        }
                        catch (Exception e)
                        {
                            Debug.Log(e);
                        }
            }
            yield return new WaitForSeconds(1);
        }
    }


    public void OnMove(UnitComponent component, FourDirection direction)
    {
        var root = ToPoint(component.Point);
        var prePoint = CalcNextPoint(root, direction);
        if (IsOutOfScene(prePoint)) //   TODO:超出地图范围
            return;
        if (Grids[prePoint.X, prePoint.Y].Type != TiledType.Normal)
            return;
        if (Grids[prePoint.X, prePoint.Y].Unit != null)
        {
            // 已经存在单位   -   切换为攻击模式
        }
        else
        {
            Grids[root.X, root.Y].Unit = null;
            component.Point = ToVector3(prePoint);
            Grids[prePoint.X, prePoint.Y].Unit = component;
            //
            component.transform.position = component.Point;
        }
    }

    public void ChangeSceneStatus()
    {

        Debug.Log("ChangeSceneStatus");
    }


    /// <summary>
    ///     创建地图场景
    /// </summary>
    /// <param name="cfgSceneId"></param>
    /// <returns></returns>
    public SceneGrid[,] CreateTiledScene(int cfgSceneId)
    {
        //  TODO: 初始化关卡地图信息
        var grids = new SceneGrid[10, 10];
        for (var i = 0; i < 10; i++)
        for (var j = 0; j < 10; j++)
            grids[i, j] = new SceneGrid
            {
                Type = TiledType.Normal
            };

        // TODO: 初始化怪物

        //  TODO: 玩家移动到出生点

        return grids;
    }

    public Point ToPoint(Vector3 vector3)
    {
        return new Point((int) vector3.x, (int) vector3.z);
    }

    public Vector3 ToVector3(Point point)
    {
        return new Vector3(point.X, 0.5f, point.Y);
    }


    public bool IsOutOfScene(Point point)
    {
        if (point.X < 0 || point.Y < 0 || point.X >= Grids.GetLength(0) || point.Y >= Grids.GetLength(1))
            return true;
        return false;
    }

    public Point CalcNextPoint(Point root, FourDirection direction)
    {
        switch (direction)
        {
            case FourDirection.Top:
                return root + UnitConst.Top;
            case FourDirection.Bottom:
                return root + UnitConst.Bottom;
            case FourDirection.Left:
                return root + UnitConst.Left;
            case FourDirection.Right:
                return root + UnitConst.Right;
            default:
                return root;
        }
    }
}


public class SceneGrid
{
    /// <summary>
    ///     坐标点
    /// </summary>
    public Vector2 Point { get; set; }

    public TiledType Type { get; set; }

    public UnitComponent Unit { get; set; }
}