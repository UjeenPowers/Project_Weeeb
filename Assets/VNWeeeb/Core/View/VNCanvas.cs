using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VNCanvas
{
    /*
    Base class for all Canvas-based graphic repesentation
    */
    protected Canvas Canvas;
    protected GameObject GameObject;
    protected Transform Transform;
    protected string CanvasName;
    public virtual void Init(GameObject main)
    {
        GameObject = main.transform.Find(CanvasName).gameObject;
        Transform = GameObject.transform;
        Canvas = GameObject.GetComponent<Canvas>();
    }
    public virtual void Hide()
    {

    }
    public virtual void Kill()
    {

    }
}
