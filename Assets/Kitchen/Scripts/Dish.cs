using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum DishState
{
	Clean,
	Dirty,
	Cleaning,
	Dried,
}

public class Dish : MonoBehaviour
{
	public DishState state;


	public void CleanUpDish()
	{
		state = DishState.Clean;
		Destroy(transform.GetChild(0).gameObject);
	}


    // Start is called before the first frame update
    void Start()
	{
		state = DishState.Dirty;
	}

    // Update is called once per frame
    void Update()
    {

    }
}
