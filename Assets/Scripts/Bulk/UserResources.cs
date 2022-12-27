using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class UserResources
{
    private const string ImagesDataPathAdditive = "/../UserImages/";
    private string ImagesDataPath = Application.dataPath + ImagesDataPathAdditive;
    public void SaveImage(Texture2D spriteTexture, string spriteName)
    {
        byte[] bytes = spriteTexture.EncodeToPNG();
        if(!Directory.Exists(ImagesDataPath)) {
            Directory.CreateDirectory(ImagesDataPath);
        }
        File.WriteAllBytes(ImagesDataPath + spriteName + ".png", bytes);
        Debug.Log("ImageSaved");
    }
    public void FindAllImages()
    {
        foreach (var item in Directory.EnumerateFiles(ImagesDataPath))
        {
            Debug.Log(item);
        }
    }

    public string FindFirstImage()
    {
        string filename = Directory.GetFiles(ImagesDataPath)[0];
        return filename;
    }
}
