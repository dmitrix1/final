using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformer : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    public LayerMask ground;
    private PolygonCollider2D _PolygonCollider2D;
    public float jumpSpeed;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        _PolygonCollider2D = GetComponent<PolygonCollider2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }   
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && _PolygonCollider2D.IsTouchingLayers(ground))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);

        }
        

    }
}
