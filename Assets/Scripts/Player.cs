using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SingletonTemplate<Player>
{

    public string Name { get; set; }

    void Start()
    {
        DontDestroyOnLoad(gameObject);   
    }

}
