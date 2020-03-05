using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBarValues : MonoBehaviour
{
    HealthBar Bar;
    int value = 100;

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Cake")
        {
            Debug.Log("Colliding with Cake");
            value--;
        }

        else if (target.gameObject.tag == "Choclate")
        {
            Debug.Log("Colliding with Chocolate");
            value--;
        }

        else if (target.gameObject.tag == "Candy")
        {
            Debug.Log("Colliding with Candy");
            value--;
        }
        
    }

    private void Update()
    {
       Bar.SetHealth(value);
    }
}
