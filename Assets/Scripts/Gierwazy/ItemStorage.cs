using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStorage : MonoBehaviour
{

    public GameObject manager;
    public bool placeInOrder;
    public int positionsX = 2;
    public int positionsY = 1;
    public int positionsZ = 2;
    //public GameObject collider;

    /*private int currentPos = 0;

    private Vector3 position;*/

    public void Start() {
        // collider = gameObject.GetComponentInParent<BoxCollider>().gameObject;
        // position = transform.position;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Grabbable")) {
            /*PlaceObject(other.gameObject);*/
            if (manager.GetComponent<GameManager>().OnItemDeliver(other.gameObject, gameObject))
                other.gameObject.SetActive(false);
        }
    }

    /*private void PlaceObject(GameObject obj) {
        if (!placeInOrder) {
            Vector3 newPosition = new Vector3(position.x + Random.Range(-1f, 1f) * transform.localScale.x / 10f,
                position.y + Random.Range(-1f, 1f) * transform.localScale.y / 10f,
                position.z + Random.Range(-1f, 1f) * transform.localScale.x / 10f);
            obj.GetComponent<Rigidbody>().isKinematic = true;
            obj.transform.position = newPosition;
        }
        else {
            int index = 0;
            for (int x = 0; x < positionsX; x++) {
                for (int z = 0; z < positionsZ; z++) {
                    for (int y = 0; y < positionsY; y++) {
                        if (index == currentPos) {
                            obj.GetComponent<Rigidbody>().isKinematic = true;
                            obj.transform.position = GetPosition(x, y, z);
                        }
                        currentPos++;

                        if (currentPos > positionsX * positionsY * positionsZ) {
                            currentPos = 0;
                            index -= currentPos;
                        }
                        if (index > currentPos)
                            break;
                    }
                }
            }
        }


    }

    public Vector3 GetPosition(int x, int y, int z) {
        Vector3 tempPos = new Vector3(
            position.x + transform.localScale.x * 0.8f * x / (positionsX + 1),
            position.y + transform.localScale.y * 0.8f * y / (positionsY + 1),
            position.z + transform.localScale.z * 0.8f * z / (positionsZ +1)
            );
        tempPos.x -= (transform.localScale.x / 4);
       // tempPos.y -= transform.localScale.y / 2;
       // tempPos.z -= transform.localScale.z / 2;
        return tempPos;
    }*/


    
}
