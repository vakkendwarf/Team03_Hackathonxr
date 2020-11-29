using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnToRandomizer : MonoBehaviour
{
    [SerializeField]
    List<GameObject> shufflers;


    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Grabbable") {
            // pick random shuffler
            sendToRandomizer(other.gameObject);
        }
    }

    public void sendToRandomizer(GameObject obj) {
        shufflers[(int)Mathf.Floor(Random.value * shufflers.Count)].GetComponent<ObjectShuffler>().RespawnObject(obj);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
