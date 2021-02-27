//-----------------------------------------------------------------
// GameObject�̊g���֐��N���X
//-----------------------------------------------------------------
using UnityEngine;
using System.Collections.Generic;

public static class GameObjectEx
{
    /// <summary>
    /// ���[���h���W�n�̍��W��ݒ�
    /// </summary>
    /// <param name="target">�ݒ肳���I�u�W�F�N�g��Transform</param>
    /// <param name="set_rot">�ݒ肷����W</param>
    public static void SetPosiotion(this Transform target, Vector3 set_rot)
    {
        Vector3 vec = Vector3.zero;
        vec.x = set_rot.x;
        vec.y = set_rot.y;
        vec.z = set_rot.z;

        target.position = vec;
    }

    /// <summary>
    /// ���[�J�����W�n�̍��W��ݒ�
    /// </summary>
    /// <param name="target">�ݒ肳���I�u�W�F�N�g��Transform</param>
    /// <param name="set_rot">�ݒ肷����W</param>
    public static void SetLocalPosiotion(this Transform target, Vector3 set_rot)
    {
        Vector3 vec = Vector3.zero;
        vec.x = set_rot.x;
        vec.y = set_rot.y;
        vec.z = set_rot.z;

        target.localPosition = vec;
    }

    /// <summary>
    /// ���[���h���W�n�̉�]�ʂ�ݒ�
    /// </summary>
    /// <param name="target">�ݒ肳���I�u�W�F�N�g��Transform</param>
    /// <param name="set_rot">�ݒ肷��l</param>
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
    /// ���[�J�����W�n�̉�]�ʂ�ݒ�
    /// </summary>
    /// <param name="target">�ݒ肳���I�u�W�F�N�g��Transform</param>
    /// <param name="set_rot">�ݒ肷��l</param>
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
    /// SetActive��null�`�F�b�N
    /// </summary>
    /// <param name="obj">�Ώۂ̃I�u�W�F�N�g</param>
    public static void Activity(this GameObject obj)
    {
        if (obj == null)
        {
            Debug.LogError("Null�̃I�u�W�F�N�g�𖳌��ɂ��悤�Ƃ��܂����B");
            return;
        }

        if (!obj.activeSelf) obj.SetActive(true);
    }

    /// <summary>
    /// SetActive��null�`�F�b�N
    /// </summary>
    /// <param name="obj">�Ώۂ̃I�u�W�F�N�g</param>
    public static void Deactivity(this GameObject obj)
    {
        if (obj == null)
        {
            Debug.LogError("Null�̃I�u�W�F�N�g�𖳌��ɂ��悤�Ƃ��܂����B");
            return;
        }

        if (obj.activeSelf) obj.SetActive(false);
    }

    /// <summary>
    /// ���ׂĂ̎q�I�u�W�F�N�g��Transform���擾
    /// </summary>
    /// <param return>���ׂĂ̎q�I�u�W�F�N�g</param>"
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
    /// ���ׂĂ̎q�I�u�W�F�N�g�̎w�肵���N���X���擾
    /// </summary>
    /// <param return>���ׂĂ̎q�I�u�W�F�N�g</param>"
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
