using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VNScene
{
    /*
    This class is supposed to offer generalized control over different aspects of visual representation.
    */
    private List<VNCanvas> Canvases;

    public VNScene(List<VNCanvas> canvases)
    {
        Canvases = canvases;
    }

    private void HideAll()
    {
        foreach(var item in Canvases)
        {
            item.Hide();
        }
    }
    private void KillAll()
    {
        foreach(var item in Canvases)
        {
            item.Kill();
        }
    }
}
