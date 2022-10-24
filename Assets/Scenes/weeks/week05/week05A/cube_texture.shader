Shader "Lecture/week05/Example/cube_texture"
{
	Properties
	{
		// 인스펙터 창에 표시되는 인터페이스들
		// 큰따옴표 안에 있는 이름이 인스펙터에서 보이는 이름
		// 여기서는 줄이 끝날 때 세미콜론 안 찍는다.
		//_Color ("Color", Color) = (1,1,1,1) // color 없이 텍스쳐만 받기
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
			//o.Albedo = c.rgb; // 천연색
			o.Albedo = (c.r + c.g + c.b) / 3; // 흑백
			o.Alpha = c.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
