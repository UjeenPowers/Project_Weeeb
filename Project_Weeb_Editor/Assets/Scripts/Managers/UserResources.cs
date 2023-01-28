using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

public class UserResources
{
    private string CurrentPackLocation;
    private PackSettings CurrentPackSettings;
    //private const string ImagesDataPathAdditive = "/../UserImages/";
    //private string ImagesDataPath = Application.dataPath + ImagesDataPathAdditive;
    public async void SelectPackLocation()
    {
        Task<string> t1 = FileDialogWrapper.instance.GetSavePath();
        string path = await t1;
        CurrentPackLocation = path;
        Debug.Log(path);
    }
    public async void CreatePackLocation()
    {
        Task<string> t1 = FileDialogWrapper.instance.GetSavePath();
        string path = await t1; //TODO: add pack naming
        CurrentPackLocation = path + "/NewPack";
        Debug.Log($"New Pack created and selected, the location is at {CurrentPackLocation}");
        Directory.CreateDirectory(CurrentPackLocation);
        CurrentPackSettings = PackSettings.CreateBlancSettings();
        var file = JsonUtility.ToJson(CurrentPackSettings);
        File.WriteAllText(CurrentPackLocation + "/PackSettings.json", file);
    }
}
