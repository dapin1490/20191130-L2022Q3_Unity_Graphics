Shader "Lecture/ExampleShader/cube_doubleTexture"
{
	Properties
	{
		// �ν����� â�� ǥ�õǴ� �������̽���
		// ū����ǥ �ȿ� �ִ� �̸��� �ν����Ϳ��� ���̴� �̸�
		// ���⼭�� ���� ���� �� �����ݷ� �� ��´�.
		//_Color ("Color", Color) = (1,1,1,1) // color ���� �ؽ��ĸ� �ޱ�
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_MainTex2 ("Albedo2 (RGB)", 2D) = "white" {}
		_LerpRange ("Lerp Range", Range(0, 1)) = 0.5
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }

		CGPROGRAM
		#pragma surface surf Standard fullforwardshadows

		sampler2D _MainTex;
		sampler2D _MainTex2;

		struct Input
		{
			float2 uv_MainTex;
			float2 uv_MainTex2;
		};

		float _LerpRange;

		void surf (Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
			fixed4 d = tex2D (_MainTex2, IN.uv_MainTex2);
			//o.Albedo = c.rgb; // õ����
			o.Albedo = lerp(c.rgb, d.rgb, _LerpRange);
			//o.Alpha = c.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
