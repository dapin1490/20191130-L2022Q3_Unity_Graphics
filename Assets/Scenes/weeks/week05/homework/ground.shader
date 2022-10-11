Shader "Custom/ground"
{
	Properties
	{
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		_MainTex2 ("Albedo (RGB)", 2D) = "white" {}
		_MainTex3 ("Albedo (RGB)", 2D) = "white" {}
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }

		CGPROGRAM
		#pragma surface surf Standard fullforwardshadows

		sampler2D _MainTex;
		sampler2D _MainTex2;
		sampler2D _MainTex3;

		struct Input
		{
			float2 uv_MainTex;
			float2 uv_MainTex2;
			float2 uv_MainTex3;
		};

		fixed4 _Color;

		void surf (Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex + _Time.y) * _Color;
			fixed4 d = tex2D (_MainTex2, IN.uv_MainTex2 + _Time.y) * _Color;
			fixed4 e = tex2D (_MainTex3, IN.uv_MainTex3 + _Time.y) * _Color;
			o.Albedo = c.rgb * d.rgb * e.rgb;
			o.Emission = c.rgb * d.rgb * e.rgb;
			o.Alpha = c.a * d.rgb * e.rgb;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
