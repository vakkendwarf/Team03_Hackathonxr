using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    //ItemStorage[] storages;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //void OnItemDeliver(GameObject recObj, GameObject storage)
    //{
    //    if (recObj.tag == "Pickupable")
    //    {
    //        if (recObj.GetComponent<Pickupable>().itemStorageToDeliver == storage)
    //        {
    //            CompleteTask(recObj.GetComponent<PickupableM>().task);
    //        }
    //    }
    //}

    void CompleteTask(t_Task task)
    {
        switch (task) 
        {
            case t_Task.t_trousers:
                break;
            case t_Task.t_towel:
                break;
            default:
                break;
        }
    }
}