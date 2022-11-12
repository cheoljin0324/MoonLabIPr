using System;
using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance = null;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(T)) as T;

                if (instance == null)
                {
                    Debug.LogError(typeof(T) + "is nothing");
                }
            }

            return instance;
        }
    }

    [SerializeField]
    private bool doNotDestroy = true;

    protected virtual void Awake()
    {
        if (CheckInstance() && doNotDestroy)
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    private bool CheckInstance()
    {
        if (instance == null)
        {
            instance = this as T;
            return true;
        }
        else if (Instance == this)
        {
            return true;
        }

        Destroy(this.gameObject);
        return false;
    }
}