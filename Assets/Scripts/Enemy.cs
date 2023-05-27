using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public Transform player;
    public float speed = 5f;
    private Animator anim;
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        anim = GetComponent<Animator>();
       
    }

    void Update()
    {

        Vector2 target = new Vector2(player.position.x, player.position.y);
        Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
        transform.position = Vector2.MoveTowards(currentPosition, target, speed * Time.deltaTime);
        if (health <= 0)
        {
            anim.SetTrigger("die");
        }
    }

    void OnDie()
    {
        Destroy(this);
    }
    
}



