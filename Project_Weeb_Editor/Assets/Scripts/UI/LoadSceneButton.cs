using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneButton : UIElement
{
    public override void Init(GameObject gameObject)
    {
        gameObject.GetComponent<EasyButton>().OnButtonClick += SaveScene;
    }
    
    private void SaveScene()
    {
        Debug.Log("Scene loaded");
        Main.instance.Manager_Scene.LoadScene();
    }
}
