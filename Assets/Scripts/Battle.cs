using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.AI;
public class Battle : MonoBehaviour
{
    private Animator anim;
    public GameObject Agent; 
   // private NavMesh agent;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isdied", false);
        //agent = GetComponent<NavMesh>();
    }

    // Update is called once per frame
    void Update()
    {
       // if (CompareTag("agent"))
        {
         //  if (Input.GetMouseButton(0))
            {
               // anim.SetBool("isdied", true);
                //Destroy(Agent);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (Input.GetMouseButton(0))
        {
            anim.SetBool("isdied", true); 
            //NavMesh.RemoveNavMeshData();
            Destroy(Agent);
        }
    }
}

  