using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class UserImage : UnityObject
{
    private static GameObject Prefab =((Resources.Load("ScriptableObjects/Prefabs")) as Prefabs).ImagePrefab;
    public string UserGivenName = "test";
    public Vector2 Pos {get; private set;}
    private Image Image;
    public Action<Vector2> OnPosChanged;
    public string FilePath;
    public void Instantiate(Transform parent)
    {
        GameObject = GameObject.Instantiate(Prefab, parent);
        GameObject.transform.Find("Image").GetComponent<ImageHandler>().OnClickAction += OnClick;
        Image = GameObject.transform.Find("Image").GetComponent<Image>();
        Pos = new Vector2(GameObject.transform.localPosition.x, GameObject.transform.localPosition.y);
    }

    private void OnClick()
    {
        Main.instance.Manager_UI.ObjectSelector.ChangeSelectedObject(this);
    }

    public void ChangeImage(string filePath)
    {
        FilePath = filePath;
        Texture2D spriteTexture = LoadTexture(filePath);
        Sprite NewSprite = Sprite.Create(spriteTexture, new Rect(0, 0, spriteTexture.width, spriteTexture.height),new Vector2(0,0), 100.0f);
        Image.sprite = NewSprite;
    }

    public void ChangePos(Vector2 pos)
    {
        GameObject.transform.localPosition = pos;
        Pos = pos;
    }

    public Texture2D LoadTexture(string FilePath) {
 
     // Load a PNG or JPG file from disk to a Texture2D
     // Returns null if load fails
 
     Texture2D Tex2D;
     byte[] FileData;
 
     if (File.Exists(FilePath)){
       FileData = File.ReadAllBytes(FilePath);
       Tex2D = new Texture2D(2, 2);           // Create new "empty" texture
       if (Tex2D.LoadImage(FileData))           // Load the imagedata into the texture (size is set automatically)
         return Tex2D;                 // If data = readable -> return texture
     }  
     return null;                     // Return null if load failed
   }

    public void Kill() //TODO: factory for images
    {
        GameObject.Destroy(GameObject);
    }
}
