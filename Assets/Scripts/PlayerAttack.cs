using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{
    private float timeBtwttack;
    public float startTimeBtwAttack;
    public Transform attackPos;
    public LayerMask enemy;
    public float attackRange;
    public int damage;
    public int myHealth;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myHealth <= 0)
        {
            SceneManager.LoadScene("loser");
        }
        if (timeBtwttack <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                Collider2D[] enemies = Physics2D.OverlapCircleAll(attackPos.position, attackRange, enemy);
                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i].GetComponent<Enemy>().TakeDamage(damage);
                }
            }

            timeBtwttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwttack -= Time.deltaTime;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

    public void TakeDamage(int ddamage)
    {
        myHealth -= ddamage;
    }
}
