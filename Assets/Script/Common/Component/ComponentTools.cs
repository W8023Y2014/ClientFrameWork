﻿using Common.Auto;
using UnityEngine;
using System.Collections.Generic;

public class ComponentTool 
{
    public static readonly ComponentTool Instance = new ComponentTool();
    private ComponentTool()
    {

    }
    public static void Attach(Transform root,Transform child)
    {
        child.transform.parent = root;
        child.localPosition = new Vector3(0, 0, 0);
        child.localScale = new Vector3(1, 1, 1);
        child.localEulerAngles = new Vector3(0, 0, 0);
    }

    public static Vector3 ConvertThriftVec3ToVec3(ThriftVector3 source)
    {
        return new Vector3(source.X / 1000.0f, source.Y / 1000.0f, source.Z / 1000.0f);
    }
    public static ThriftVector3 ConvertVec3ToThriftVec3(Vector3 source)
    {
        ThriftVector3 res = new ThriftVector3();
        res.X = (int)(source.x * 1000);
        res.Y = (int)(source.y * 1000);
        res.Z = (int)(source.z * 1000);
        return res;
    }
    public static T FindChildComponent<T>(string objName, GameObject fromParent) where T : Component
    {
        GameObject obj = FindChild(objName, fromParent);
        if (null != obj)
        {
            return obj.GetComponent<T>();
        }
        else
        {
            return null;
        }
    }
    public static GameObject FindChild(string objName, GameObject fromParent)
    {
        if( null == fromParent)
        {
            return GameObject.Find(objName);
        }
        GameObject parent = fromParent;
        Transform child = FindChild(parent.transform, objName);
        if (null != child)
        {
            return child.gameObject;
        }
        else
        {
            return null;
        }
    }
    public static void FindAllChildComponents<T>(Transform parent, ref List<T> result) where T : Component
    {
        T elem = parent.GetComponent<T>();
        if (null != elem)
        {
            result.Add(elem);
        }
        for (int i = 0; i < parent.childCount; ++i)
        {
            FindAllChildComponents<T>(parent.GetChild(i), ref result);
        }
    }
    private static Transform FindChild(Transform parent, string objName)
    {
        if (parent.name == objName)
        {
            return parent;
        }
        else
        {
            foreach (Transform item in parent)
            {
                Transform child = FindChild(item, objName);
                if (null != child)
                {
                    return child;
                }
            }
            return null;
        }
    } 
}
