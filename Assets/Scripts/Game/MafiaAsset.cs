using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Assets.Scripts.Game
{
    internal partial class Mafia
    {
        #region 资源加载

        public static Dictionary<string, AssetBundle> AssetBundleCache = new Dictionary<string, AssetBundle>();


        /// <summary>
        ///     异步加载AssetBundle
        /// </summary>
        /// <param name="path"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        internal static IEnumerator AsyncLoadAssetBundle(string path, Action<AssetBundle> callback)
        {
            var request = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, path));
            yield return request;
            callback(request.assetBundle);
        }

        /// <summary>
        ///     异步加载GameObject. 从AssetBundle加载指定的资源并返回.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="resName"></param>
        /// <param name="callback"></param>
        /// <returns></returns>
        internal static IEnumerator AsyncLoadGameObject(string path, string resName, Action<GameObject> callback)
        {
            var request = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, path));
            yield return request;
            var assetBundle = request.assetBundle;
            if (assetBundle == null)
            {
                Error("Failed to load AssetBundle! Path:{0}", new object[] {path});
                yield break;
            }
            var assetLoadRequest = assetBundle.LoadAssetAsync<GameObject>(resName);
            yield return assetLoadRequest;
            callback(assetLoadRequest.asset as GameObject);
        }

        internal static IEnumerator LoadAsyncCoroutine(string path, string resName, Action<GameObject> callback)
        {
            var request = AssetBundle.LoadFromFileAsync(Path.Combine(Application.streamingAssetsPath, path));
            yield return request;
            while (!request.isDone)
                yield return false;
            var assetBundle = request.assetBundle;
            if (assetBundle == null)
            {
                UnityEngine.Debug.Log("Failed to load AssetBundle!");
                yield break;
            }
            var assetLoadRequest = assetBundle.LoadAssetAsync<GameObject>(resName);
            yield return assetLoadRequest;
            callback(assetLoadRequest.asset as GameObject);
        }

        #endregion
    }
}