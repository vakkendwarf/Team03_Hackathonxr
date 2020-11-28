using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskObject : MonoBehaviour 
{
    public GameObject sibling;

   
    private void OnDisable() {
        sibling.SetActive(true);
        //sibling.GetComponent<Rigidbody>().isKinematic = false;
    }
}
