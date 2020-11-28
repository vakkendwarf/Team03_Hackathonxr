using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupableM : MonoBehaviour
{
    [SerializeField]
    public GameObject itemStorageToDeliver;
    public t_Task task;
    public Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
