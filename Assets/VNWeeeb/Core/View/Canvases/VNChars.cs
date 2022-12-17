using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VNChars : VNCanvas
{
    public VNChars(GameObject main)
    {
        CanvasName = "CharsCanvas";
        Init(main);
    }
    public override void Hide()
    {
        
    }
}
