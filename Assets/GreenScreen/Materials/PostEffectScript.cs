using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostEffectScript : MonoBehaviour {

	// Use this for initialization
	void OnRenderImage ( RenderTexture src, RenderTexture dest) {
        // src is the full rendered scene tat you would normally 
        // send directly to the monitor. We are intercepting
        // this so we can do a bit more work, before passin it on.
        Color[] pixels = new Color[1920 * 1080];

        for (int x = 0; x < 1920; x++)
        {
            for (int y = 0; y < 1080; y++)
            {
                pixels[x + y * 1080].r = Mathf.Pow(2.18f, 3.17f);
            }
        }

        // probably apply some kind of texture.SetPixels(pixels);

        Graphics.Blit(src, dest);
		
	}
}
