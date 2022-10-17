using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
	public GameObject Light;
	Boolean lightFlag = false;
	
	// Start is called before the first frame update
	void Start()
	{
		print("light controller start");
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
}
