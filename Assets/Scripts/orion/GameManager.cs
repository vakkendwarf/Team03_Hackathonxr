using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    List<t_Task> tasksDone;
    GameObject mum;
    public TextMesh subtitles;
    t_Task currTask = t_Task.t_socks;

    private float start_time;


    public GameObject bookHandler;

    void Start()
    {
        tasksDone = new List<t_Task>();
        start_time = Time.time;
        StartCoroutine(StartingSubtitles());
    }

    IEnumerator StartingSubtitles()
    {
        yield return new WaitForSeconds(7f);
        subtitles.text = "Start with sorting dirty clothes. \nPut your socks in the dirty clothes basket.";
    }

    string[] yiellings = {
        "No! You are not listening to me!",
        "Why are you so stubborn?",
        "Do I speak slurredly?",
        "Your father will be mad!"
    };
    string[] praising = {
        "Good job!",
        "That's my son!",
        "You are really smart little man.",
        "Keep going!",
        "Perfect!",
        "Excellent!"
    };

    IEnumerator ShowCurrTask()
    {
        yield return new WaitForSeconds(4f);

        switch (currTask)
        {
            case t_Task.t_socks:
                //subtitles.text = "Store your underwear in the wardrobe.";
                subtitles.text = "Put your socks in the dirty clothes basket";
                break;
            case t_Task.t_underwear:
                //subtitles.text = "Put your T-shirt in the dirty clothes basket.";
                subtitles.text = "Store your underwear in the wardrobe.";
                break;
            case t_Task.t_tshirt:
                //subtitles.text = "Dump the trash to the dumpster.";
                subtitles.text = "Put your T-shirt in the dirty clothes basket.";
                break;
            case t_Task.t_trash:
                //subtitles.text = "Now collect your books!";
                subtitles.text = "Dump the trash to the dumpster.";
                break;
            case t_Task.t_books:
                //subtitles.text = "Good job! Your room is finally clean!";
                subtitles.text = "Now collect your books! Novel on upper shelf,\neducational below.";
                break;
            default:
                break;
        }
    }

    void Update()
    {
        
    }

    public bool OnItemDeliver(GameObject recObj, GameObject storage)
    {
        if (recObj.tag == "Grabbable")
        {
            if (recObj.GetComponent<PickupableM>().itemStorageToDeliver == storage )
            {
                if (currTask == t_Task.t_books) {
                    if (bookHandler.GetComponent<BookHandler>().BookOnPlace(recObj)) {
                        CompleteTask(recObj.GetComponent<PickupableM>().task);
                    }
                    subtitles.text = praising[(int)Mathf.Floor(Random.value * praising.Length)];
                    return true;
                }
                else if (currTask == recObj.GetComponent<PickupableM>().task) {
                    CompleteTask(recObj.GetComponent<PickupableM>().task);
                    return true;
                }
            }
            else
            {
                // if game just started 
                if (Time.time - start_time < 4f) {
                    gameObject.GetComponent<SpawnToRandomizer>().sendToRandomizer(recObj);
                } else {
                    subtitles.text = yiellings[(int)Mathf.Floor(Random.value * yiellings.Length)];
                    //subtitles.text = "No! You are not listening to me!";
                    recObj.transform.position = recObj.GetComponent<PickupableM>().startingPos;
                    recObj.GetComponent<Rigidbody>().isKinematic = false;
                    StartCoroutine(ShowCurrTask());
                }
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
            tasksDone.Add(task);
            currTask = task + 1;

            subtitles.text = praising[(int)Mathf.Floor(Random.value * praising.Length)];
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