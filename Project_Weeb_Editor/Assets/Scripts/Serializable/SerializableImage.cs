using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SerializableImage
{
    public SerializableImage(UserImage image)
    {
        ImagePosition = image.Pos;
        ImagePath = image.FilePath;
    }
    public string ImagePath;
    public Vector2 ImagePosition;
}
