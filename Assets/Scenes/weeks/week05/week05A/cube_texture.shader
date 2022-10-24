Shader "Lecture/week05/Example/cube_texture"
{
	Properties
	{
		// �ν����� â�� ǥ�õǴ� �������̽���
		// ū����ǥ �ȿ� �ִ� �̸��� �ν����Ϳ��� ���̴� �̸�
		// ���⼭�� ���� ���� �� �����ݷ� �� ��´�.
		//_Color ("Color", Color) = (1,1,1,1) // color ���� �ؽ��ĸ� �ޱ�
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }

		CGPROGRAM
		#pragma surface surf Standard fullforwardshadows

		sampler2D _MainTex;

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex); // * _Color;
			//o.Albedo = c.rgb; // õ����
			o.Albedo = (c.r + c.g + c.b) / 3; // ���
			o.Alpha = c.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
