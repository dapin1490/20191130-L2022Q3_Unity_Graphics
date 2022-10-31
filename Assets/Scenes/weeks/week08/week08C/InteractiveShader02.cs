using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveShader02 : MonoBehaviour
{
    int Brightness = 1;
    Renderer render;

    // Start is called before the first frame update
    void Start()
    {
        render = gameObject.GetComponent<Renderer>();
        render.material.SetInt("_Brightness", Brightness);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Brightness = -1 * Brightness;
        render.material.SetInt("_Brightness", Brightness);
    }
}
