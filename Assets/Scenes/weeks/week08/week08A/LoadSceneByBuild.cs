using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneByBuild : MonoBehaviour
{
	public Object SceneToLoad;

	// Start is called before the first frame update
	void Start()
	{
		print("LoadSceneByBuild script start");
	}

	private void OnMouseDown()
	{
		SceneManager.LoadScene(SceneToLoad.name);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
