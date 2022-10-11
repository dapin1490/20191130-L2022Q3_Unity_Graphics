Shader "Custom/cylinder"
{
	Properties
	{
		_Color ("Color", Color) = (1,1,1,1)
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
			o.Albedo = float3((_Red + _Time.x) % 3, (_Green + _Time.y) % 3, (_Blue + _Time.z) % 3);
		}
		ENDCG
	}
	FallBack "Diffuse"
}
