using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_UI : Manager
{
    private CreateImageButton CreateImageButton;
    public ObjectSelector ObjectSelector {get; private set;}
    public Manager_UI()
    {
        Transform UItransform = GameObject.Find("MainCanvas").transform.Find("UI");

        CreateImageButton = new CreateImageButton();
        CreateImageButton.Init(UItransform.Find("CreateImage").gameObject);

        ObjectSelector = new ObjectSelector();
        ObjectSelector.Init(UItransform.Find("ObjectSelector").gameObject);
    }
}
