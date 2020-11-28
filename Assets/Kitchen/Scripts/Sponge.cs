using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sponge : MonoBehaviour
{

	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("colliding with sponge");
		if(collision.gameObject.tag == "dirt")
			Destroy(collision.gameObject);
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
