using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class transitiondoorscript : MonoBehaviour {
    Animator anim;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("spaceentered");
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("spaceentered");
    }
}
