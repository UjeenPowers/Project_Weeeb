using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    /*
    Class for handling managers
    */
    public static Main instance {get; private set;}
    public Manager_UI Manager_UI {get; private set;}
    public Manager_Instantiator Manager_Instantiator {get; private set;}
    void Start()
    {
        instance = this;
        Manager_UI = new Manager_UI();
        Manager_Instantiator = new Manager_Instantiator();
    }

    // void Update()
    // {
        
    // }
}
