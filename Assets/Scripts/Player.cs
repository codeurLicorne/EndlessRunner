using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * speed);
    }
}
