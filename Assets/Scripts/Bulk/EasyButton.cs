using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyButton : MonoBehaviour
{
    public Action OnButtonClick;
    public void Click()
    {
        OnButtonClick?.Invoke();
    }
}
