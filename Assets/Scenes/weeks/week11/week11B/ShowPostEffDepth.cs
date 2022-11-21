using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPostEffDepth : MonoBehaviour
{
	Shader Shad;
	Material Mat;
	public float depth;

	// Start is called before the first frame update
	void Start()
	{
		print("PostEffDepth script start");
		Shad = Shader.Find("Lecture/week11/PostEffDepth");
		Mat = new Material(Shad);
	}

	// Update is called once per frame
	void Update()
	{
		depth = Mathf.Clamp(depth, 0.0f, 1.0f);
	}

	public void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		Mat.SetFloat("_Depth", depth);
		Graphics.Blit(src, dest, Mat, 0);
	}

	public void OnDisable()
	{
		if (Mat)
		{
			DestroyImmediate(Mat);
		}
	}
}
