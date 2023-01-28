using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PackSettings
{
    public string Name;
    public static PackSettings CreateBlancSettings()
    {
        var settings = new PackSettings();
        return settings;
    }
}
