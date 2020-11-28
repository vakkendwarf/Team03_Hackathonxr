using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStorage : MonoBehaviour
{

   

    public GameObject manager;

    private HashSet<GameObject> insideObjects;
    private Vector3 position;

    public void Start() {
        if (manager == null) {
            Debug.LogError("No controler for item storaghe");
        }

        insideObjects = new HashSet<GameObject>();

        position = gameObject.GetComponentInParent<BoxCollider>().transform.position;
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Grabbable")) {
            if (! insideObjects.Contains(other.gameObject)) {
                insideObjects.Add(other.gameObject);
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.transform.position = position;
                Debug.Log(other.name);
                manager.GetComponent<GameManager>().OnItemDeliver(other.gameObject, gameObject);
            }
        }
    }


    
}
