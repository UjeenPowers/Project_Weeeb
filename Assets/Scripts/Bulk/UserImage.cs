using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserImage : UnityObject
{
    private static GameObject Prefab =((Resources.Load("ScriptableObjects/Prefabs")) as Prefabs).ImagePrefab;
    private Image Image;
    public void Instantiate(Transform parent)
    {
        Debug.Log("instantiate blank image");
        GameObject = GameObject.Instantiate(Prefab, parent);
        var RectTransform = GameObject.GetComponent<RectTransform>();

        RectTransform.localScale = new Vector3(1,1,1);
        RectTransform.anchorMin = new Vector2(0.5f,0.5f);
        RectTransform.anchorMax = new Vector2(0.5f,0.5f);
        
        Debug.Log("ImageInstantiated");
    }
}
