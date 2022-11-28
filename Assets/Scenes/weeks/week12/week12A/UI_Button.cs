using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button : MonoBehaviour
{
    public InputField input_compo;
    public Text text_compo;

    // Start is called before the first frame update
    void Start()
    {
        print("UI_Button script start");
    }

    // // Update is called once per frame
    // void Update()
    // {

    // }

    public void OnClick_SetText() {
        text_compo.text = input_compo.text;
    }
}
