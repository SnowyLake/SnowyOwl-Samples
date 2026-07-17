using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using Sirenix.OdinInspector;
using SnowyOwl.GraphicsFramework;
using UnityEngine.Experimental.GlobalIllumination;
using CoreUtils = SnowyOwl.GraphicsFramework.CoreUtils;

[ExecuteAlways]
public class MiscComponent : MonoBehaviour
{
    public Renderer targetRenderer;
    private void OnEnable()
    {
        var settings = CoreUtils.GetGlobalSettings();
    }

    void Update()
    {
        
    }

    [Button]
    public void AddCustomComponent()
    {
        if (SwyoWorldGraphicsSettings.InstanceTryAdd<CustomWorldGraphicsComponent>())
        {
            
        }
    }
    
    [Button]
    public void RemoveCustomComponent()
    {
        if (SwyoWorldGraphicsSettings.InstanceTryRemove<CustomWorldGraphicsComponent>())
        {
        }
    }
}

[TypeRegistryItem(Name = "自定义组件")]
public class CustomWorldGraphicsComponent : WorldGraphicsComponent
{
    public override void OnEnable(SwyoWorldGraphicsSettings owner)
    {
        Debug.Log("OnEnable");
    }

    public override void Start(SwyoWorldGraphicsSettings owner)
    {
        Debug.Log("Start");
    }

    public override void OnDisable(SwyoWorldGraphicsSettings owner)
    {
        Debug.Log("OnDisable");
    }
}