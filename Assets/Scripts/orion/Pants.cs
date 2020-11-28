using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pants : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color prim = new Color();
        Color sec = new Color();

        prim.r = Random.Range(0, 255);
        prim.g = Random.Range(0, 255);
        prim.b = Random.Range(0, 255);

        sec.r = Random.Range(0, 255);
        sec.g = Random.Range(0, 255);
        sec.b = Random.Range(0, 255);

        while (System.Math.Abs(prim.r - sec.r) < 30)
            sec.r = Random.Range(0, 255);
        while (System.Math.Abs(prim.g - sec.g) < 30)
            sec.g = Random.Range(0, 255);
        while (System.Math.Abs(prim.b - sec.b) < 30)
            sec.b = Random.Range(0, 255);

        GetComponent<Material>().SetColor("PantsPrim_Custom", prim);
        GetComponent<Material>().SetColor("PantsSec_Custom", sec);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
