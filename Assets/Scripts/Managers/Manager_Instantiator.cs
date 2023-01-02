using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Instantiator : Manager
{
    private Transform ParentTransform;
    public Manager_Instantiator()
    {
        ParentTransform = GameObject.Find("ParentTransform").transform;
    }
    
    public void Instantiate(InstantiateType type)
    {
        switch (type)
        {
            case InstantiateType.Image:
                InstantiateImage();
                break;
        }
    }
    
    public void InstantiateImage()
    {
        var image = new UserImage();
        image.Instantiate(ParentTransform);
        Main.instance.Manager_Scene.AddImageToScene(image);
    }
    public void InstantiateImage(Vector2 pos, string filePath)
    {
        var image = new UserImage();
        image.Instantiate(ParentTransform);
        image.ChangePos(pos);
        image.ChangeImage(filePath);
        Main.instance.Manager_Scene.AddImageToScene(image);
    }
}

public enum InstantiateType
{
    Image,
    Audio
}
