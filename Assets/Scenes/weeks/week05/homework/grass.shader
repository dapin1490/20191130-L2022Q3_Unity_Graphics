Shader "Custom/grass"
{
	Properties
	{
		_Color ("Color", Color) = (1,1,1,1)
		_Red ("Red", Range(0, 1)) = 0
		_Green ("Green", Range(0, 1)) = 0
		_Blue ("Blue", Range(0, 1)) = 0
		_Alpha ("Alpha", Range(0, 1)) = 1
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
		float _Alpha;

		void surf (Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = float3(_Red * _Alpha, _Green * _Alpha, _Blue * _Alpha);
		}
		ENDCG
	}
	FallBack "Diffuse"
}
