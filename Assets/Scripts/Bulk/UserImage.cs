using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserImage : UnityObject
{
    private static GameObject Prefab =((Resources.Load("ScriptableObjects/Prefabs")) as Prefabs).ImagePrefab;
    public string UserGivenName = "test";
    private Image Image;
    public void Instantiate(Transform parent)
    {
        GameObject = GameObject.Instantiate(Prefab, parent);
        GameObject.transform.Find("Image").GetComponent<ImageHandler>().OnClickAction += OnClick;

        Debug.Log("ImageInstantiated");
    }

    private void OnClick()
    {
        Main.instance.Manager_UI.ObjectSelector.ChangeSelectedObject(this);
    }

    public void Kill() //TODO: factory for images
    {
        GameObject.Destroy(GameObject);
    }
}
