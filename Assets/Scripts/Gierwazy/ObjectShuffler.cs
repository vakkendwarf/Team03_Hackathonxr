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
            Vector3 position = new Vector3(Random.value * spawnBox.x, Random.value * spawnBox.x, Random.value * spawnBox.x);
            position = transform.TransformPoint(position - spawnBox / 2);
            obj.transform.position = position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
