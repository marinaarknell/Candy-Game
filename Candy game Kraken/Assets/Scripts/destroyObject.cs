using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class destroyObject : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Main Character")
        {
            Destroy(this.gameObject);
        }
    }
}
