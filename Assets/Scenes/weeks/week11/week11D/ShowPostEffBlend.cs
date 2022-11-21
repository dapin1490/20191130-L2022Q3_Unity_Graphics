using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPostEffBlend : MonoBehaviour
{
	Shader Shad;
	Material Mat;
	// public float Grayness;
	public Texture2D Blendtex;
	public float opacity;

	// Start is called before the first frame update
	void Start()
	{
		print("PostEffBlend script start");
		Shad = Shader.Find("Lecture/week11/PostEffBlend");
		Mat = new Material(Shad);
	}

	// Update is called once per frame
	void Update()
	{
		opacity = Mathf.Clamp(opacity, 0.0f, 1.0f);
	}

	public void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		Mat.SetTexture("_BlendTex", Blendtex);
		Mat.SetFloat("_Opacity", opacity);
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
