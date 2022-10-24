Shader "Lecture/week05/Example/cube_dbTexAlpha"
{
	Properties
	{
		// 인스펙터 창에 표시되는 인터페이스들
		// 큰따옴표 안에 있는 이름이 인스펙터에서 보이는 이름
		// 여기서는 줄이 끝날 때 세미콜론 안 찍는다.
		//_Color ("Color", Color) = (1,1,1,1) // color 없이 텍스쳐만 받기
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
			//o.Albedo = c.rgb; // 천연색
			//o.Albedo = lerp(c.rgb, d.rgb, d.a);
			o.Albedo = lerp(d.rgb, c.rgb, d.a);
			//o.Alpha = c.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
