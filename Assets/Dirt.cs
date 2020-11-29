using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{

    public GameObject dish;
    private void Start() {
        dish = transform.parent.gameObject;
    }

    public void TouchedBySponge(bool value) {
        if (dish.GetComponent<Dish>().isUnderSink)
            Destroy(gameObject);
        //dish.GetComponent<Dish>().DirtRemoving(value);
    }
    
}
