using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class WardrobeDoorsAnimationController : MonoBehaviour
{

    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        if(!anim)
            anim = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<HandCollider>())
        {
            if (!anim.GetBool("isOpening"))
            {
                anim.SetBool("isOpening", true);
                StartCoroutine(ChangeAnimationBoolToFalse());
            }
        }
    }

    IEnumerator ChangeAnimationBoolToFalse()
    {
        yield return new WaitForSeconds(.7f);
        anim.SetBool("isOpening", false);
    }


}
