using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    List<t_Task> tasksDone;
    GameObject mum;

    void Start()
    {
        tasksDone = new List<t_Task>();
    }

    void Update()
    {
        
    }

    public bool OnItemDeliver(GameObject recObj, GameObject storage)
    {
        if (recObj.tag == "Grabbable")
        {
            if (recObj.GetComponent<PickupableM>().itemStorageToDeliver == storage)
            {
                CompleteTask(recObj.GetComponent<PickupableM>().task);
                return true;
            }
            else
            {
                //mum throws shoe and shouts --
                recObj.transform.position = recObj.GetComponent<PickupableM>().startingPos;
                recObj.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
        return false;
    }

    void CompleteTask(t_Task task)
    {
        bool alreadyCompleted = false;
        for (int i = 0; i < tasksDone.Count; i++)
        {
            if (task == tasksDone[i])
                alreadyCompleted = true;
        }

        if (!alreadyCompleted)
        {
            switch (task)
            {
                case t_Task.t_trousers:
                    //mum play voice
                    Debug.Log("trousers delivered");
                    break;
                case t_Task.t_towel:
                    break;
                default:
                    break;
            }

            tasksDone.Add(task);

            if (tasksDone.Count == (int)t_Task.t_end)
            {
                EndGame();
            }
        }
    }

    void EndGame()
    {
        //ggwp
    }
}