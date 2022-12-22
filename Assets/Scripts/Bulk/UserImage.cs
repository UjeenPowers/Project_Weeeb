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
    private Image Image;
    public void Instantiate(Transform parent)
    {
        GameObject = GameObject.Instantiate(Prefab, parent);
        GameObject.transform.Find("Image").GetComponent<ImageHandler>().OnClickAction += OnClick;
        Image = GameObject.transform.Find("Image").GetComponent<Image>();

        Debug.Log("ImageInstantiated");
    }

    private void OnClick()
    {
        Main.instance.Manager_UI.ObjectSelector.ChangeSelectedObject(this);
    }

    public void ChangeImage(string filePath)
    {
        Texture2D SpriteTexture = LoadTexture(filePath);
        Debug.Log(SpriteTexture);
        Sprite NewSprite = Sprite.Create(SpriteTexture, new Rect(0, 0, SpriteTexture.width, SpriteTexture.height),new Vector2(0,0), 100.0f);
        Image.sprite = NewSprite;
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
