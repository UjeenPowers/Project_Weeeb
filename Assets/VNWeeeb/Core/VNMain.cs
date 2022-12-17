using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class VNMain : MonoBehaviour
{
    /*
    This class is planned to be a go-to place for connecting Unity part of VN engine with the logical part.
    I don't want to build the logic in MonoBehaviours, therefore i will use this class as a reference to Unity Updates and 
    application lifecycle
    */
    public static GameObject GameObject;

    public Action OnUpdate;
    public Action OnOnEnable;
    public Action OnOnDisable;
    void Awake()
    {
        new VNInit();
        GameObject = gameObject;
    }

    void Update()
    {
        OnUpdate?.Invoke();
    }

    void OnEnable()
    {
        OnOnEnable?.Invoke();
    }

    void OnDisable()
    {
        OnOnDisable?.Invoke();
    }
}
