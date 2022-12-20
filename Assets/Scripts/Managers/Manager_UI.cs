using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_UI : Manager
{
    private CreateImageButton CreateImageButton;
    public Manager_UI()
    {
        Transform UItransform = GameObject.Find("MainCanvas").transform.Find("UI");
        new CreateImageButton(UItransform.Find("CreateImage").GetComponent<EasyButton>());
    }
}
