using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class playerMovement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb2d;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal") * speed;
        movement.y = Input.GetAxisRaw("Vertical") * speed;
    }

    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
    }
}
