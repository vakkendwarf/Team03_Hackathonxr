using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class OnHoverSubtitlesController : MonoBehaviour
{

    private Grabbable grabbable;
    public TextMesh m_text;
    public string m_itemName;
    // Start is called before the first frame update
    void Start()
    {
        if (!m_text)
            m_text = GetComponentInChildren<TextMesh>();
        m_text.text = "";
        grabbable = GetComponent<Grabbable>();
    }


    private void Update()
    {
        if (grabbable.grabber)
        {
            m_text.text = m_itemName;
        }
        else
        {
            m_text.text = "";
        }
    }

}
