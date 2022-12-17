using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VNInitGraphics
{
    public VNInitGraphics()
    {
        GameObject mainObject = VNMain.GameObject;
        List<VNCanvas> canvases = new List<VNCanvas>();
        canvases.Add(new VNDialog(mainObject));
        canvases.Add(new VNChars(mainObject));
        canvases.Add(new VNUI(mainObject));
        canvases.Add(new VNBG(mainObject));
        new VNScene(canvases);
    }
}
