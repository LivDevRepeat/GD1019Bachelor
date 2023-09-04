Shader "Custom/PixelatedTextureToPalette"
{
    Properties
    {
        _MainTex ("Main Texture", 2D) = "white" {}
        _PaletteTex ("Palette Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags

{

	"Queue" = "Transparent"

        "IgnoreProjector" = "True"

        "RenderType" = "Transparent"

        "PreviewType" = "Plane"

        "CanUseSpriteAtlas" = "True"

}

 

Cull Off

Lighting Off

ZWrite Off

Blend One OneMinusSrcAlpha
        
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            sampler2D _PaletteTex;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 mainColor = tex2D(_MainTex, i.uv);
                
                // For pixelated effect
                fixed2 paletteCoord = mainColor.rg ;
          
                
                fixed4 paletteColor = tex2D(_PaletteTex, paletteCoord);
                
                return paletteColor *= mainColor.a;
            }
            ENDCG
        }
    }
}
