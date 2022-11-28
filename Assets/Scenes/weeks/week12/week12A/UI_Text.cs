using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Text : MonoBehaviour
{
    public GameObject gameobj;
    
    // Start is called before the first frame update
    void Start()
    {
        print("UI_Text script start");
        // string objname = gameobj.name;
        GetComponent<Text>().text = gameobj.name + " made by dapin1490";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
