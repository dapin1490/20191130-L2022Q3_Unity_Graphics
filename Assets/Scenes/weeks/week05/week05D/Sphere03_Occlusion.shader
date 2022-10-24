Shader "Lecture/week05/Example/Sphere03_Occlusion"
{
    Properties
    {
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
        _NormalMap ("NormalMap(Bump)", 2D) = "bump" {}
        _Occlusion ("Occlusion", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows

        sampler2D _MainTex;
        sampler2D _NormalMap;
        sampler2D _Occlusion;

        struct Input
        {
            float2 uv_MainTex;
            float2 uv_NormalMap;
            //float2 uv_Occlusion; // 메인텍스나 노말맵 uv 그대로 사용하기로 함
        };

        half _Glossiness;
        half _Metallic;

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a;

            fixed3 normap = UnpackNormal(tex2D (_NormalMap, IN.uv_NormalMap));
            o.Normal = normap;

            o.Occlusion = tex2D (_Occlusion, IN.uv_MainTex);
        }
        ENDCG
    }
    FallBack "Diffuse"
}
