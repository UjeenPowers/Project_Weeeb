using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPackButton :  UIElement
{
    public override void Init(GameObject gameObject)
    {
        gameObject.GetComponent<EasyButton>().OnButtonClick += SelectPack;
    }
    
    private void SelectPack()
    {
        // Debug.Log("starting saving pack");
        Main.instance.UserResources.SelectPackLocation();
    }
}
