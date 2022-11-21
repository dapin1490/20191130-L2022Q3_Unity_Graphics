using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGrayScale : MonoBehaviour
{
	Shader Shad;
	Material Mat;
	public float Grayness;

	// Start is called before the first frame update
	void Start()
	{
		print("PostEffDepth script start");
		Shad = Shader.Find("Lecture/week11/GrayScale");
		Mat = new Material(Shad);
	}

	// Update is called once per frame
	void Update()
	{
		Grayness = Mathf.Clamp(Grayness, 0.0f, 1.0f); // Grayness의 값을 0과 1 사이로 제한
	}

	/// <summary>
	/// OnRenderImage is called after all rendering is complete to render image.
	/// </summary>
	/// <param name="src">The source RenderTexture.</param>
	/// <param name="dest">The destination RenderTexture.</param>
	public void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		Mat.SetFloat("_Grayness", Grayness);
		Graphics.Blit(src, dest, Mat, 0);
	}

	/// <summary>
	/// This function is called when the behaviour becomes disabled or inactive.
	/// </summary>
	public void OnDisable()
	{
		if (Mat)
		{
			DestroyImmediate(Mat);
		}
	}
}
