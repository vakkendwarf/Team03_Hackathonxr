using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dryer : MonoBehaviour
{
	private static int dishLimit = 3;
	private int currentDish = 0;

	public float dryTimeSeconds = 2f;

	private float transform_offset = 1.3f;


	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("colliding with dryer");

		var dish = collision.gameObject.GetComponent<Dish>();
		if (dish)
		{
			if (dish.state == DishState.Clean)
			{
//				if (!occupied)
//				{
//					StartCoroutine(DryDish(dish));
//				}

				if(currentDish < dishLimit)
				{
					StartCoroutine(DryDish(dish, currentDish++));
				}
			}
		}
	}



	private IEnumerator DryDish(Dish dish, int slot)
	{
		var pos = new Vector3(slot * transform_offset, 0.5f, 0f);

		dish.transform.SetParent(this.transform);
		dish.transform.localPosition = pos;

		//dish.gameObject.transform.position = transform.position + bias;
		Destroy(dish.GetComponent<Rigidbody>());

		yield return new WaitForSeconds(dryTimeSeconds);

		dish.state = DishState.Dried;
		dish.GetComponent<Renderer>().material.color = Color.blue;
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
