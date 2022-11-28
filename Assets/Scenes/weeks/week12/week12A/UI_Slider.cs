using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Slider : MonoBehaviour
{
    public GameObject gameobj;
    Material colormat;
    
    // Start is called before the first frame update
    void Start()
    {
        print("UI_Slider script start");
        colormat = gameobj.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChanged_SetColor() 
    {
        float slide = GetComponent<Slider>().value;
        print("slider value changed to " + slide);

        Color c = new Color(slide, slide, slide, 1);
        colormat.SetColor("_Color", c);
    }
}
