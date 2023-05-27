using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrlDung : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))*speed;
    }
}
