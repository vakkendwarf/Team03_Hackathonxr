using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sponge : MonoBehaviour
{

	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("colliding with sponge");
        if (collision.gameObject.tag == "dirt")
            //Destroy(collision.gameObject);
            collision.gameObject.GetComponent<Dirt>().TouchedBySponge(true);
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("colliding with sponge");
        if (other.gameObject.tag == "dirt")
            //Destroy(other.gameObject);
            other.gameObject.GetComponent<Dirt>().TouchedBySponge(true);
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "dirt")
            //Destroy(other.gameObject);
            other.gameObject.GetComponent<Dirt>().TouchedBySponge(false);
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
