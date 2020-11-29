using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkWash : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other) {
        // check whether it is dish
        if (other.GetComponent<Dish>() != null) {
            other.GetComponent<Dish>().SetIsUnderSink(true);

        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.GetComponent<Dish>() != null) {
            other.GetComponent<Dish>().SetIsUnderSink(false);
        }
    }
}
