using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

public class UserResources
{
    private string CurrentPackLocation;
    private const string ImagesDataPathAdditive = "/../UserImages/";
    private string ImagesDataPath = Application.dataPath + ImagesDataPathAdditive;
    public async void SelectPackLocation()
    {
        Task<string> t1 = FileDialogWrapper.instance.GetSavePath();
        string path = await t1;
        CurrentPackLocation = path;
    }
    public async void CreatePackLocation()
    {
        Task<string> t1 = FileDialogWrapper.instance.GetSavePath();
        string path = await t1; //TODO: add pack naming
        CurrentPackLocation = path;
    }
    // public void SaveImage(Texture2D spriteTexture, string spriteName)
    // {
    //     byte[] bytes = spriteTexture.EncodeToPNG();
    //     if(!Directory.Exists(ImagesDataPath)) {
    //         Directory.CreateDirectory(ImagesDataPath);
    //     }
    //     File.WriteAllBytes(ImagesDataPath + spriteName + ".png", bytes);
    //     Debug.Log("ImageSaved");
    // }
    // public void FindAllImages()
    // {
    //     foreach (var item in Directory.EnumerateFiles(ImagesDataPath))
    //     {
    //         Debug.Log(item);
    //     }
    // }

    // public string FindFirstImage()
    // {
    //     string filename = Directory.GetFiles(ImagesDataPath)[0];
    //     return filename;
    // }
}
