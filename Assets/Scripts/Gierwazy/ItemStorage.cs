using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStorage : MonoBehaviour
{

    public GameObject manager;
    //public GameObject collider;

    private Vector3 position;

    public void Start() {
        //collider = gameObject.GetComponentInParent<BoxCollider>().gameObject;
        position = transform.position;
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Grabbable")) {
            PlaceObject(other.gameObject);
            manager.GetComponent<GameManager>().OnItemDeliver(other.gameObject, gameObject);
        }
    }

    private void PlaceObject(GameObject obj) {
        Vector3 newPosition = new Vector3(position.x + Random.Range(-1f, 1f) * transform. localScale.x/10f, 
            position.y + Random.Range(-1f, 1f) * transform.localScale.y/ 10f, 
            position.z + Random.Range(-1f, 1f) * transform.localScale.x/ 10f);
        obj.transform.position = newPosition;
        obj.GetComponent<Rigidbody>().isKinematic = true;


    }


    
}
