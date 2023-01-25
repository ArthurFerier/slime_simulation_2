using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computeShaderExample : MonoBehaviour
{

    public ComputeShader computeShader;

    private RenderTexture _src;

    private void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        if (_src == null)
        {
            _src = new RenderTexture(160, 90, 24);
            _src.enableRandomWrite = true;
            _src.Create();
        }
        
        computeShader.SetTexture(0, "Texture", _src);
        // tells the shader which kernel to dispatch and how many thread groups to use
        // so we divide our image size by our thread size of each group
        computeShader.Dispatch(0, _src.width/8, _src.height/8, 1);
        
        Graphics.Blit(_src, dest);
    }
}
