using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackSaveButton :  UIElement
{
    public override void Init(GameObject gameObject)
    {
        gameObject.GetComponent<EasyButton>().OnButtonClick += SaveToPack;
    }
    
    private void SaveToPack()
    {
        Debug.Log("starting saving pack");
        Main.instance.Manager_Packs.SavePack();
    }
}
