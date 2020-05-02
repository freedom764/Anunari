using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    public float speed = 8f;

    Rigidbody2D rb;

    public float movement = 0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * speed;

    }
    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
