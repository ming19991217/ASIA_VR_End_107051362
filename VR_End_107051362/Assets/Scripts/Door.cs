using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.name == "Player")
        {
            anim.SetTrigger("in");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "Player")
        {
            anim.SetTrigger("in");
        }
    }
}
