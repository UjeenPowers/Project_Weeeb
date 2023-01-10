using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Manager_Scene : Manager
{
    private List<UserImage> Images = new List<UserImage>();
    public void AddImageToScene(UserImage image)
    {
        Images.Add(image);
    }
    public void SaveCurrentScene()
    {
        SerializableScene scene = new SerializableScene();
        foreach(var item in Images)
        {
            scene.Images.Add(new SerializableImage(item));
        }
        string json = JsonUtility.ToJson(scene);
        File.WriteAllText((Application.persistentDataPath+"/testJson.json"),json);
        Debug.Log($"Scene saved at {Application.persistentDataPath+"/testJson.json"}");
    }

    public void LoadScene()
    {
        string json = File.ReadAllText(Application.persistentDataPath+"/testJson.json");
        SerializableScene scene = JsonUtility.FromJson<SerializableScene>(json);
        foreach (var item in scene.Images)
        {
            Main.instance.Manager_Instantiator.InstantiateImage(item.ImagePosition, item.ImagePath);
        }
        Debug.Log(json);
    }
}
