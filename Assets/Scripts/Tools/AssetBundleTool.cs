#if UNITY_EDITOR

using UnityEditor;

public class AssetBundleTool
{
    [MenuItem("Assets/Build AssetBundles")]
    private static void BuildAllAssetBundles()
    {
        //"./Assets/AssetBundles"
        //Application.streamingAssetsPath
        BuildPipeline.BuildAssetBundles("E:\\C\\Git@GitHub\\G-WuLin\\Assets\\MafiaAssets\\",
            BuildAssetBundleOptions.AppendHashToAssetBundleName, BuildTarget.StandaloneWindows);
    }
}
#endif