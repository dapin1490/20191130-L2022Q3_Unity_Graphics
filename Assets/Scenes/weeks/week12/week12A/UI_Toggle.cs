using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Toggle : MonoBehaviour
{
    public GameObject gameobj; // public : 인스펙터 통해 접근 가능
    Material colormat;
    Color c1, c2;
    bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        print("UI_Toggle script start");
        colormat = gameobj.GetComponent<Renderer>().material;
        c1 = new Color(1, 1, 1, 1);
        c2 = new Color(0, 0, 1, 1);
    }

    // Update is called once per frame
    // void Update()
    // {

    // }

    public void OnValueChanged_SetColor()
    {
        isOn = GetComponent<Toggle>().isOn;
        if (isOn) {
            print("Toggle on - set color (1, 1, 1, 1)");
            colormat.SetColor("_Color", c1);
        }
        else {
            print("Toggle off - set color (0, 0, 1, 1)");
            colormat.SetColor("_Color", c2);
        }
    }
}
