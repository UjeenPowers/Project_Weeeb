using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VNUI : VNCanvas
{
    public VNUI(GameObject main)
    {
        CanvasName = "UICanvas";
        Init(main);
    }
    public override void Hide()
    {
        
    }
}
