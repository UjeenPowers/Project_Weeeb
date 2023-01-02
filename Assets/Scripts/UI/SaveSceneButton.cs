using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSceneButton : UIElement
{
    public override void Init(GameObject gameObject)
    {
        gameObject.GetComponent<EasyButton>().OnButtonClick += SaveScene;
    }
    
    private void SaveScene()
    {
        Debug.Log("Scene saved");
        Main.instance.Manager_Scene.SaveCurrentScene();
    }
}
