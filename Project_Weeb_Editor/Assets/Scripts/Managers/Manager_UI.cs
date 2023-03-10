using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_UI : Manager
{
    private CreateImageButton CreateImageButton;
    private SaveSceneButton SaveSceneButton;
    private LoadSceneButton LoadSceneButton;
    private PackSaveButton PackSaveButton;
    private SelectPackButton SelectPackButton;
    private CreatePackButton CreatePackButton;
    public ObjectSelector ObjectSelector {get; private set;}
    public Manager_UI()
    {
        Transform UItransform = GameObject.Find("MainCanvas").transform.Find("UI");

        CreateImageButton = new CreateImageButton();
        CreateImageButton.Init(UItransform.Find("CreateImage").gameObject);

        SaveSceneButton = new SaveSceneButton();
        SaveSceneButton.Init(UItransform.Find("SaveScene").gameObject);

        LoadSceneButton = new LoadSceneButton();
        LoadSceneButton.Init(UItransform.Find("LoadScene").gameObject);

        PackSaveButton = new PackSaveButton();
        PackSaveButton.Init(UItransform.Find("SavePack").gameObject);

        SelectPackButton = new SelectPackButton();
        SelectPackButton.Init(UItransform.Find("SelectPack").gameObject);

        CreatePackButton = new CreatePackButton();
        CreatePackButton.Init(UItransform.Find("CreatePack").gameObject);

        ObjectSelector = new ObjectSelector();
        ObjectSelector.Init(UItransform.Find("ObjectSelector").gameObject);
    }
}
