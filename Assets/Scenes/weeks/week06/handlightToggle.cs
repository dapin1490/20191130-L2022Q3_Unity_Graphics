using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handlightToggle : MonoBehaviour
{
	public GameObject Light;
	Boolean lightFlag = false;

	// Start is called before the first frame update
	void Start()
	{
		print("handlightToggle script start");
	}

	// Update is called once per frame
	void Update()
	{
        if (Input.GetKeyDown(KeyCode.T))
        {
            print("F keydown");
            print("light active = " + lightFlag);
            Light.SetActive(lightFlag);
            lightFlag = !lightFlag;
        }
    }
}
