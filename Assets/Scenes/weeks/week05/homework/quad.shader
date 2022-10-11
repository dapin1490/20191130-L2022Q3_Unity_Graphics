Shader "Custom/quad"
{
	Properties
	{
		_Color ("Color", Color) = (1,1,1,1)
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

		void surf (Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = _Time.y % 5;
			o.Alpha = float((_Time.y % 5) * 0.1);
		}
		ENDCG
	}
	FallBack "Diffuse"
}
