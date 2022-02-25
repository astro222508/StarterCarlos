using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollText : MonoBehaviour
{
    public float ScrollX = 0.5f;
    public float ScrollY = 0.5f;
    // Update is called once per frame
    void Update()
    {
        float Offsetx = Time.time * ScrollX;
        float Offsety = Time.time * ScrollY;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Offsetx, Offsety);
    }
}
