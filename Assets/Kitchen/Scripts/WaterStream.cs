using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterStream : MonoBehaviour
{
	public float cleaningTimeSec = 12f;
	public float cleaningDistance = 5f;

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("colliding with water");

		var dish = other.gameObject.GetComponent<Dish>();
		if (dish)
		{
			if (dish.state == DishState.Dirty)
			{
				dish.state = DishState.Cleaning;
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
				dish.state = DishState.Dirty;
				Debug.Log($"interrupted washing");
				break;
			}
			yield return new WaitForSeconds(checkTime);
		}

		if (dish.state == DishState.Cleaning)
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
