using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePackButton :  UIElement
{
    public override void Init(GameObject gameObject)
    {
        gameObject.GetComponent<EasyButton>().OnButtonClick += CreatePack;
    }
    
    private void CreatePack()
    {
        // Debug.Log("starting saving pack");
        Main.instance.UserResources.CreatePackLocation();
    }
}
