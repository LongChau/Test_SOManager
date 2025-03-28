using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Init();
    }

    public void Init()
    {
        Debug.Log("DataManager.Init()");
    }
}
