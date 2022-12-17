using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VNDialog : VNCanvas
{
    public VNDialog(GameObject main)
    {
        CanvasName = "DialogCanvas";
        Init(main);
    }
    public override void  Hide()
    {
        
    }
}
