using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookHandler : MonoBehaviour
{

    [SerializeField]
    HashSet<GameObject> books;
    HashSet<GameObject> booksOnPlace;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool BookOnPlace(GameObject book) {
        booksOnPlace.Add(book);
        foreach (GameObject bookCheck in books) {
            if (!booksOnPlace.Contains(bookCheck))
                return false;
        }
        return true;
    }
}
