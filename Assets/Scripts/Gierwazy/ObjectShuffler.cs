using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShuffler : MonoBehaviour
{

    [SerializeField]
    List<GameObject> objectsToShuffle;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject obj in objectsToShuffle) {
            var spawnBox = transform.localScale;
            Vector3 boundary = new Vector3(Random.value * spawnBox.x, Random.value * spawnBox.y, Random.value * spawnBox.z);
            //position = transform.TransformPoint(boundary - spawnBox / 2);
            obj.GetComponent<Rigidbody>().isKinematic = true;
            obj.transform.position = transform.TransformPoint(boundary - spawnBox / 2);
            obj.GetComponent<TaskObject>().RandomizeColor();

            obj.GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
