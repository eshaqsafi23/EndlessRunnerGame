using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTexture : MonoBehaviour
{
    public float scrollSpeed = 1.0f;
    void Start()
    {
        
    }

   
    void Update()
    {
        var offset = Time.time * scrollSpeed;
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
