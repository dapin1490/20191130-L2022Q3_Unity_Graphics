using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
	Scene CurrentScene;
	
	// Start is called before the first frame update
	void Start()
	{
		CurrentScene = gameObject.scene;
		print(CurrentScene.name);
	}

	private void OnMouseDown()
	{
		if (CurrentScene.name == "week08A_scene01")
		{
			SceneManager.LoadScene("week08A_scene02");
		}
		else if (CurrentScene.name == "week08A_scene02")
		{
			SceneManager.LoadScene("week08A_scene01");
		}
	}

	// Update is called once per frame
	void Update()
	{
		
	}
}
