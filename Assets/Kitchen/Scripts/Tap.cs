using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap : MonoBehaviour
{
	public ParticleSystem particleSystem;
	public bool opened;

	void OnCollisionEnter(Collision collision)
	{
		Debug.Log($"colliding, state {opened}");

		Switch(); // should be invoked by hand in VR
	}

	public void Switch()
	{
		if (!opened)
		{
			Open();
		}
		else
		{
			Close();
		}

		opened = !opened;
	}

	public void Open()
	{
		var waterStream = GameObject.Find("water_stream");
		waterStream.GetComponent<BoxCollider>().enabled = true;
		particleSystem.Play();
	}

	public void Close()
	{
		var waterStream = GameObject.Find("water_stream");
		waterStream.GetComponent<BoxCollider>().enabled = false;
		particleSystem.Stop();
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
