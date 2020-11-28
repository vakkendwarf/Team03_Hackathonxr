using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskObject : MonoBehaviour 
{
    public GameObject sibling;

   
    private void Disable() {
        sibling.SetActive(true);
        gameObject.SetActive(false);
    }

    /*private void OnDisable() {
        sibling.SetActive(true);
    }*/

    public void RandomizeColor() {
        Color color = new Color(Random.value * 0.7f + 0.15f, Random.value * 0.7f + 0.15f, Random.value * 0.7f + 0.15f);
        gameObject.GetComponent<Renderer>().material.color = color;
        sibling.GetComponent<Renderer>().material.color = color;
    }
}
