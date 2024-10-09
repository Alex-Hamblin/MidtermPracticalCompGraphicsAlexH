Shader "Custom/ColourTint"
{
    Properties
    {
        _ColorTint ("Tint", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
    
        #pragma surface surf Lambert finalcolor:mycolor

        

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

       
        fixed4 _ColorTint;
        void mycolor (Input IN, SurfaceOutput o, inout fixed4 color)
        {
            color *= _ColorTint;

        }

       

        void surf (Input IN, inout SurfaceOutput o)
        {
            o.Albedo = tex2D (_MainTex, IN.uv_MainTex).rgb;
        }
        ENDCG
    }
    FallBack "Diffuse"  
}
