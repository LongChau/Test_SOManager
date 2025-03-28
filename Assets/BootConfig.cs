using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BootConfig", menuName = "ScriptableObjects/BootConfig", order = 1)]
public class BootConfig : ScriptableObject
{
    [SerializeField] DataManager dataManager;

    public static bool IsCreated {get; set;} = false;
    public static Action OnFistSceneLoaded;

    void OnEnable()
    {
        if (IsCreated)
            return;

        Debug.Log("BootConfig.OnEnable()");
        OnFistSceneLoaded += () =>
        {
            Debug.Log("BootConfig.OnFistSceneLoaded()");
            Instantiate(dataManager);
        };
    }

    void OnDisable()
    {
        Debug.Log("BootConfig.OnDisable()");
        
    }
}
