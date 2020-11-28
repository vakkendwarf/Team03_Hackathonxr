using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish : MonoBehaviour
{
	public bool isDirty;

	public bool isCurrentlyBeingCleaned;


	public void CleanUpDish()
	{
		Destroy(transform.GetChild(0).gameObject);
	}


    // Start is called before the first frame update
    void Start()
	{
		isDirty = true;
	}

    // Update is called once per frame
    void Update()
    {

    }
}
