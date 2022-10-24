Shader "Lecture/week05/Example/cube_dbTexAlpha"
{
	Properties
	{
		// �ν����� â�� ǥ�õǴ� �������̽���
		// ū����ǥ �ȿ� �ִ� �̸��� �ν����Ϳ��� ���̴� �̸�
		// ���⼭�� ���� ���� �� �����ݷ� �� ��´�.
		//_Color ("Color", Color) = (1,1,1,1) // color ���� �ؽ��ĸ� �ޱ�
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_MainTex2 ("Albedo2 (RGB)", 2D) = "white" {}
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

		void surf (Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
			fixed4 d = tex2D (_MainTex2, IN.uv_MainTex2);
			//o.Albedo = c.rgb; // õ����
			//o.Albedo = lerp(c.rgb, d.rgb, d.a);
			o.Albedo = lerp(d.rgb, c.rgb, d.a);
			//o.Alpha = c.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
