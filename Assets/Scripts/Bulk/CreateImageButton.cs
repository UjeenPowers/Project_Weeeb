using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateImageButton
{
    public CreateImageButton(EasyButton button)
    {
        button.OnButtonClick += CreateImage;
    }
    
    private void CreateImage()
    {
        Main.instance.Manager_Instantiator.Instantiate(InstantiateType.Image);
        Debug.Log("CreateImage");
    }
}
