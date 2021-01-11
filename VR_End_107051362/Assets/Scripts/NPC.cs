using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private Animator anim;
    public bool isDead;

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Environment")
        {
            if (!isDead)
            {
                anim.SetTrigger("dead");
                isDead = true;
            }

        }
    }
    
}
