using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish : MonoBehaviour
{
	public bool isDirty;

	public Material cleanDishMaterial;
	public Material dirtyDishMaterial;
	public bool isCurrentlyBeingCleaned;

    private Renderer renderer;


	public void CleanUpDish()
	{

        if (cleanDishMaterial)
		{
            renderer.material = cleanDishMaterial;
			isDirty = false;
		}
	}


    // Start is called before the first frame update
    void Start()
	{
        renderer = GetComponent<Renderer>();

        if (cleanDishMaterial)
		{
            renderer.material = dirtyDishMaterial;
			isDirty = true;
		}
	}

    // Update is called once per frame
    void Update()
    {
        if(!isDirty)
        {
            if(renderer.material == dirtyDishMaterial)
                renderer.material = cleanDishMaterial;
        }
    }
}
