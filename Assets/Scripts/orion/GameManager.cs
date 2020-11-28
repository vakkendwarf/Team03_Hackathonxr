using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    List<t_Task> tasksDone;
    GameObject mum;
    TextMesh subtitles;

    void Start()
    {
        tasksDone = new List<t_Task>();
    }

    void Update()
    {
        
    }

    public void OnItemDeliver(GameObject recObj, GameObject storage)
    {
        if (recObj.tag == "Grabbable")
        {
            if (recObj.GetComponent<PickupableM>().itemStorageToDeliver == storage)
            {
                CompleteTask(recObj.GetComponent<PickupableM>().task);
            }
            else
            {
                //mum throws shoe and shouts --
                recObj.transform.position = recObj.GetComponent<PickupableM>().startingPos;
                recObj.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
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
                    subtitles.text = "Now collect your trash!";
                    break;
                case t_Task.t_trash:
                    subtitles.text = "Now collect your books!";
                    break;
                case t_Task.t_books:
                    subtitles.text = "Good job! Your room is finally clean!";
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