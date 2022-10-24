Shader "Lecture/week07/Example/Lambert"
{
	Properties
	{
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }

		CGPROGRAM
		#pragma surface surf ExLambert noambient

		sampler2D _MainTex;

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o)
		{
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}

		float4 LightingExLambert(SurfaceOutput surfout, float3 lightDir, float atten) {
			return float4(1, 0, 0, 1);
		}
		ENDCG
	}
	FallBack "Diffuse"
}
