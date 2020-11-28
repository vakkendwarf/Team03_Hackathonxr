using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish : MonoBehaviour
{
	public bool isDirty;

	public Material cleanDishMaterial;
	public Material dirtyDishMaterial;
	public bool isCurrentlyBeingCleaned;

	public void CleanUpDish()
	{
		if (cleanDishMaterial)
		{
			GetComponent<Renderer>().material = cleanDishMaterial;
			isDirty = false;
		}
	}


    // Start is called before the first frame update
    void Start()
	{
		if (cleanDishMaterial)
		{
			GetComponent<Renderer>().material = dirtyDishMaterial;
			isDirty = true;
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
