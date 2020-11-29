using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<Renderer>().material.mainTexture = new Texture2D(16, 16);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
