using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterStream : MonoBehaviour
{
	public float cleaningTimeSec = 2f;
	public float cleaningDistance = 5f;


	void OnCollisionEnter(Collision collision)
	{
		Debug.Log("colliding with water");

		var dish = collision.gameObject.GetComponent<Dish>();
		if (dish)
		{
			if (dish.isDirty && !dish.isCurrentlyBeingCleaned)
			{
				dish.isCurrentlyBeingCleaned = true;
				StartCoroutine(CheckDistance(dish));
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("colliding with water");

		var dish = other.gameObject.GetComponent<Dish>();
		if (dish)
		{
			if (dish.isDirty && !dish.isCurrentlyBeingCleaned)
			{
				dish.isCurrentlyBeingCleaned = true;
				StartCoroutine(CheckDistance(dish));
			}
		}
	}

	private IEnumerator CheckDistance(Dish dish)
	{
		Debug.Log($"check distance start");
		float checkTime = 0.1f;
		for (float i = 0; i < cleaningTimeSec; i += checkTime)
		{
			var dist = (dish.gameObject.transform.position - transform.position).magnitude;
			Debug.Log($"checking for time {i} distance {dist} ");
			if (dist > cleaningDistance)
			{
				dish.isCurrentlyBeingCleaned = false;
				Debug.Log($"interrupted washing");
				break;
			}
			yield return new WaitForSeconds(checkTime);
		}

		if (dish.isCurrentlyBeingCleaned)
		{
			Debug.Log($"cleaned dish");
			// successfully cleaned dish
			dish.CleanUpDish();
		}
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
