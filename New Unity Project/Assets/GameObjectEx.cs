//-----------------------------------------------------------------
// GameObjectの拡張関数クラス
//-----------------------------------------------------------------
using UnityEngine;
using System.Collections.Generic;

public static class GameObjectEx
{
    /// <summary>
    /// ワールド座標系の座標を設定
    /// </summary>
    /// <param name="target">設定されるオブジェクトのTransform</param>
    /// <param name="set_rot">設定する座標</param>
    public static void SetPosiotion(this Transform target, Vector3 set_rot)
    {
        Vector3 vec = Vector3.zero;
        vec.x = set_rot.x;
        vec.y = set_rot.y;
        vec.z = set_rot.z;

        target.position = vec;
    }

    /// <summary>
    /// ローカル座標系の座標を設定
    /// </summary>
    /// <param name="target">設定されるオブジェクトのTransform</param>
    /// <param name="set_rot">設定する座標</param>
    public static void SetLocalPosiotion(this Transform target, Vector3 set_rot)
    {
        Vector3 vec = Vector3.zero;
        vec.x = set_rot.x;
        vec.y = set_rot.y;
        vec.z = set_rot.z;

        target.localPosition = vec;
    }

    /// <summary>
    /// ワールド座標系の回転量を設定
    /// </summary>
    /// <param name="target">設定されるオブジェクトのTransform</param>
    /// <param name="set_rot">設定する値</param>
    public static void SetRotation(this Transform target, Quaternion set_rot)
    {
        Quaternion rot = Quaternion.identity;
        rot.x = set_rot.x;
        rot.y = set_rot.y;
        rot.z = set_rot.z;
        rot.w = 1f;

        target.rotation = rot;
    }

    /// <summary>
    /// ローカル座標系の回転量を設定
    /// </summary>
    /// <param name="target">設定されるオブジェクトのTransform</param>
    /// <param name="set_rot">設定する値</param>
    public static void SetLocalRotation(this Transform target, Quaternion set_rot)
    {
        Quaternion rot = Quaternion.identity;
        rot.x = set_rot.x;
        rot.y = set_rot.y;
        rot.z = set_rot.z;
        rot.w = 1f;

        target.localRotation = rot;
    }

    /// <summary>
    /// SetActiveのnullチェック
    /// </summary>
    /// <param name="obj">対象のオブジェクト</param>
    public static void Activity(this GameObject obj)
    {
        if (obj == null)
        {
            Debug.LogError("Nullのオブジェクトを無効にしようとしました。");
            return;
        }

        if (!obj.activeSelf) obj.SetActive(true);
    }

    /// <summary>
    /// SetActiveのnullチェック
    /// </summary>
    /// <param name="obj">対象のオブジェクト</param>
    public static void Deactivity(this GameObject obj)
    {
        if (obj == null)
        {
            Debug.LogError("Nullのオブジェクトを無効にしようとしました。");
            return;
        }

        if (obj.activeSelf) obj.SetActive(false);
    }

    /// <summary>
    /// すべての子オブジェクトのTransformを取得
    /// </summary>
    /// <param return>すべての子オブジェクト</param>"
    public static List<Transform> GetComponentsInChiledren(this GameObject parent)
    {
        var child = parent.GetComponentsInChildren<Transform>();
        var obj_list = new List<Transform>(child.Length);

        foreach (var obj in child)
        {
            obj_list.Add(obj);
        }

        return obj_list;
    }

    /// <summary>
    /// すべての子オブジェクトの指定したクラスを取得
    /// </summary>
    /// <param return>すべての子オブジェクト</param>"
    public static List<Class> GetComponentsInChiledren<Class>(this GameObject parent)
    {
        var child = parent.GetComponentsInChildren<Class>();
        var obj_list = new List<Class>(child.Length);

        foreach (var obj in child)
        {
            obj_list.Add(obj);
        }

        return obj_list;
    }

}
