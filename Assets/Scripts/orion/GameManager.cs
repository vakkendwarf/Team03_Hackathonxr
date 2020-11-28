using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    List<t_Task> tasksDone;
    GameObject mum;
    TextMesh subtitles;
    t_Task currTask = t_Task.t_trousers;

    void Start()
    {
        tasksDone = new List<t_Task>();

        StartCoroutine(StartingSubtitles());
    }

    IEnumerator StartingSubtitles()
    {
        yield return new WaitForSeconds(7f);
        subtitles.text = "Start with sorting dirty clothes. \nPut your pants in the dirty clothes basket.";
    }

    IEnumerator ShowCurrTask()
    {
        yield return new WaitForSeconds(4f);

        switch (currTask)
        {
            case t_Task.t_trousers:
                subtitles.text = "Store your underwear in the wardrobe.";
                break;
            case t_Task.t_underwear:
                subtitles.text = "Put your T-shirt in the dirty clothes basket.";
                break;
            case t_Task.t_tshirt:
                subtitles.text = "Dump the trash to the dumpster.";
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
    }

    void Update()
    {
        
    }

    public void OnItemDeliver(GameObject recObj, GameObject storage)
    {
        if (recObj.tag == "Grabbable")
        {
            if (recObj.GetComponent<PickupableM>().itemStorageToDeliver == storage && currTask == recObj.GetComponent<PickupableM>().task)
            {
                CompleteTask(recObj.GetComponent<PickupableM>().task);
            }
            else
            {
                subtitles.text = "No! You are not listening to me!";
                recObj.transform.position = recObj.GetComponent<PickupableM>().startingPos;
                recObj.GetComponent<Rigidbody>().isKinematic = true;
                StartCoroutine(ShowCurrTask());
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
            tasksDone.Add(task);
            currTask = task + 1;

            subtitles.text = "Good job!";
            StartCoroutine(ShowCurrTask());

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