using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VNBG : VNCanvas
{
    public VNBG(GameObject main)
    {
        CanvasName = "BGCanvas";
        Init(main);
    }
    public override void Hide()
    {

    }
}
