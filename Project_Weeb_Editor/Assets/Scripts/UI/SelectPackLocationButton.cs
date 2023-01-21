using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPackLocationButton :  UIElement
{
    public override void Init(GameObject gameObject)
    {
        gameObject.GetComponent<EasyButton>().OnButtonClick += SelectPackLocation;
    }
    
    private void SelectPackLocation()
    {
        // Debug.Log("starting saving pack");
        Main.instance.UserResources.SelectPackLocation();
    }
}
