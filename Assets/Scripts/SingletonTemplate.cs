using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTemplate<TSingleton> : MonoBehaviour where TSingleton : MonoBehaviour
{
    static TSingleton instance = null;

    public static TSingleton Instance => instance;

    void Awake()
    {
        if(instance)
        {
            Destroy(gameObject);
            return;
        }

        instance = this as TSingleton;
    }
}
