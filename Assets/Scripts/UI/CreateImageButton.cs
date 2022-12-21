using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateImageButton : UIElement
{
    // public CreateImageButton(EasyButton button)
    // {
    //     button.OnButtonClick += CreateImage;
    // }
    public override void Init(GameObject gameObject)
    {
        gameObject.GetComponent<EasyButton>().OnButtonClick += CreateImage;
    }
    
    private void CreateImage()
    {
        Main.instance.Manager_Instantiator.Instantiate(InstantiateType.Image);
        Debug.Log("CreateImage");
    }
}
