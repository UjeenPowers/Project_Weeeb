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
                var iamge = new UserImage();
                iamge.Instantiate(ParentTransform);
                break;
        }
    }
}

public enum InstantiateType
{
    Image,
    Audio
}
