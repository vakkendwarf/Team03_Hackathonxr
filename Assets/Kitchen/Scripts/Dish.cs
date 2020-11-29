using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dish : MonoBehaviour
{

	public bool isDirty;

	public bool isUnderSink;
	public bool isCurrentlyBeingCleaned;

	public bool isDone;


	public void CleanUpDish() {
		Destroy(transform.GetChild(0).gameObject);
	}


	// Start is called before the first frame update
	void Start() {
		isDirty = true;
	}

	// Update is called once per frame
	void Update() {
	}

	// leagcy
	public void SetIsUnderSink(bool value) {
		if (value) {
			isUnderSink = true;
			isCurrentlyBeingCleaned = true;
		}
		else {
			isUnderSink = false;
			isCurrentlyBeingCleaned = false;
		}
	}



	// Wersja z obsługą czasu szurowanie brudu... debuger mi się na tym wywala, wiec uproscilem. Gierwazy
	/*public bool isDirty;

	public bool isUnderSink;
	public bool isCurrentlyBeingCleaned;

	public float timeToClean = 4f;

	private float timeCleanedTemp;
	private float timeCleaned;

	private GameObject dirt;


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
		if (isCurrentlyBeingCleaned) {
			if (timeCleaned + Time.time - timeCleanedTemp > timeToClean) {
				CleanUpDish();
            }
        } else {
			if (timeCleaned > timeToClean) {
				CleanUpDish();
			}
        }
    }

	public void SetIsUnderSink(bool value) {
		if (value) {
			isUnderSink = true;
        } else {
			isUnderSink = false;
			isCurrentlyBeingCleaned = false;
        }
    }

	public void SetCurrentlyCleaned(bool value) {
		if (value && !isCurrentlyBeingCleaned) {
			isCurrentlyBeingCleaned = true;
			timeCleanedTemp = Time.time;
        } 
		if (!value) {
			isCurrentlyBeingCleaned = false;
			timeCleaned = Time.time - timeCleanedTemp;
		}
    }

	public void DirtRemoving(bool value) {
		if (value) {
			if (isUnderSink) {
				SetCurrentlyCleaned(true);
			}
		} else {
			SetCurrentlyCleaned(false);
        }
    }*/


}
