using System;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : Component
{

    private static T ins;
    public static T Ins
    {
        get
        {
            if (ins == null)
            {
                Type theType = typeof(T);
                ins = (T)FindObjectOfType(theType);
                if (ins == null)
                {
                    GameObject go = new GameObject(theType.ToString());
                    ins = go.AddComponent<T>();
                    GameObject rootObj = GameObject.Find("RootObj");
                    if (rootObj == null)
                    {
                        rootObj = new GameObject("RootObj");
                        DontDestroyOnLoad(rootObj);
                    }
                    go.transform.SetParent(rootObj.transform, false);
                }
            }
            return ins;
        }
    }

    protected virtual void Awake()
    {
        if (ins != null && ins.gameObject != gameObject)
        {
            if (Application.isPlaying)
            {
                Destroy(gameObject);
            }
            else
            {
                DestroyImmediate(gameObject);
            }
        }
        else if (ins == null)
        {
            ins = GetComponent<T>();
        }
        DontDestroyOnLoad(gameObject);
        Init();
    }
    protected virtual void Init()
    {

    }
}

