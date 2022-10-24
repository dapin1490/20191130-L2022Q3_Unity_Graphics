Shader "Lecture/week05/Example/cube"
{
	Properties
	{
		// 인스펙터 창에 표시되는 인터페이스들
		// 큰따옴표 안에 있는 이름이 인스펙터에서 보이는 이름
		// 여기서는 줄이 끝날 때 세미콜론 안 찍는다.
		_Color ("Color", Color) = (1,1,1,1)
		_MainTex ("Albedo (RGB)", 2D) = "white" {}
		//_Glossiness ("Smoothness", Range(0,1)) = 0.5
		//_Metallic ("Metallic", Range(0,1)) = 0.0
		_Red ("Red", Range(0, 1)) = 0
		_Green ("Green", Range(0, 1)) = 0
		_Blue ("Blue", Range(0, 1)) = 0
	}
	SubShader
	{
		Tags { "RenderType"="Opaque" }
		//LOD 200

		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Standard fullforwardshadows

		// Use shader model 3.0 target, to get nicer looking lighting
		//#pragma target 3.0

		sampler2D _MainTex;

		struct Input
		{
			float2 uv_MainTex;
		};

		//half _Glossiness;
		//half _Metallic;
		fixed4 _Color;
		float _Red;
		float _Green;
		float _Blue;

		//// Add instancing support for this shader. You need to check 'Enable Instancing' on materials that use the shader.
		//// See https://docs.unity3d.com/Manual/GPUInstancing.html for more information about instancing.
		//// #pragma instancing_options assumeuniformscaling
		//UNITY_INSTANCING_BUFFER_START(Props)
		//    // put more per-instance properties here
		//UNITY_INSTANCING_BUFFER_END(Props)

		void surf (Input IN, inout SurfaceOutputStandard o)
		{
			// Albedo comes from a texture tinted by color
			fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
			//o.Albedo = c.rgb;
			o.Albedo = float3(_Red, _Green, _Blue);
			// Metallic and smoothness come from slider variables
			//o.Metallic = _Metallic;
			//o.Smoothness = _Glossiness;
			o.Alpha = c.a;
		}
		ENDCG
	}
	FallBack "Diffuse"
}
