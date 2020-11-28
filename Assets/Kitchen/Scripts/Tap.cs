using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour
{

	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("colliding");

		var waterStream = GameObject.Find("water_stream");
		waterStream.GetComponent<MeshRenderer>().enabled = true;
	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
