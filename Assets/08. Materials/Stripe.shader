Shader "Unlit/Stripe"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            float4 frag (v2f i) : SV_Target
            {
                float lineCount = 10;		//1. 10개의 라인갯수
                float2 c = i.uv;
                float color = (c.x * lineCount);	//2. uv.x값을  소수점이 있는 0,0f ~ 50.0f으로 늘림
                color = floor (color);		//3. 0~50까지 1단위로 변경
                color = color / 2;			//4. 0~25까지 0.5단위로 변경, 소수점은 0또는 0.5다.
                color = frac (color);		//5. 0또는 0.5값만 있음
                color *=2;					//6. 0또는 1값으로만 표현되도록 변경
                return color;
            }
            ENDCG
        }
    }
}
