using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BootScene
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void RegisterEvent()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void Init()
    {
        Debug.Log("BootScene.Init()");
        BootConfig.IsCreated = true;
        BootConfig.OnFistSceneLoaded?.Invoke();
        // var bootConfig = ScriptableObject.CreateInstance<BootConfig>();
        // bootConfig.IsCreated = true;
        // bootConfig.OnBootSceneLoaded?.Invoke();
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode arg1)
    {
        Debug.Log("BootScene.OnSceneLoaded() " + scene.name);
        if (scene.name == "Boot")
        {
            
        }
    }

}
