using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyMovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPosition.x < -50 )
        {
            Destroy(this.gameObject);
        }
        
    }
}
