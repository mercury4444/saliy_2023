using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    float x;
    Vector2 move;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal");
        move = new Vector2(x * speed, rb.velocity.y);
        rb.velocity = move;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
