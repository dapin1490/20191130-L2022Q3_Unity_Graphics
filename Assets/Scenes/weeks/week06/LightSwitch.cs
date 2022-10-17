using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
	public GameObject Light;
	Boolean lightFlag = false;

	// Start is called before the first frame update
	void Start()
	{
        print("light switch start");
    }

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.L))
		{
			print("L keydown");
			print("light active = " + lightFlag);
			Light.SetActive(lightFlag);
			lightFlag = !lightFlag;
		}
	}

	private void OnMouseDown()
	{
		print(gameObject.name + " mouse down");

		if (gameObject.name == "light switch")
		{
            print("light active = " + lightFlag);
            Light.SetActive(lightFlag);
            lightFlag = !lightFlag;
        }
    }
}
