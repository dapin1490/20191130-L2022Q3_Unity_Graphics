Shader "Lecture/week05/Custom/Sphere03_addInteface"
{
	Properties
	{
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_Red ("Red", Range(0, 1)) = 0
		_Green ("Green", Range(0, 1)) = 0
		_Blue ("Blue", Range(0, 1)) = 0
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

		fixed4 _Color;
		float _Red;
		float _Green;
		float _Blue;

		void surf (Input IN, inout SurfaceOutputStandard o)
		{
			// Albedo comes from a texture tinted by color
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
			//o.Albedo = c.rgb;
			o.Albedo = float3(_Red, _Green, _Blue);
			o.Alpha = c.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
