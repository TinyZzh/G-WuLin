#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

public class AssetBundleTool
{
    [MenuItem("Assets/Build AssetBundles")]
    private static void BuildAllAssetBundles()
    {
        //"./Assets/AssetBundles"
        //  "E:\\C\\Git@GitHub\\G-WuLin\\Assets\\MafiaAssets\\"
        BuildPipeline.BuildAssetBundles(Application.streamingAssetsPath,
            BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
    }
}
#endif