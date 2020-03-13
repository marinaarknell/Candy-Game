using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarValues : MonoBehaviour
{
    HealthBar Bar;
    int value = 100;
    public int health;
    public float stamina;
    public float maxStamina;
    public float happiness;
    public float addictionLevel;

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Sugar")
        {
            addictionLevel++;
            Debug.Log("collide with candy");
        }
    }

    void Start()
    {
        stamina = maxStamina;
    }

    void Update()
    {
        Bar.SetHealth(health);

        stamina -= Time.deltaTime;

        /*if (health < 1)
        {
            SceneManager.LoadScene(2);
        }*/

        if (Mathf.Round(stamina) == 0)
        {
            for (int i = 0; i < addictionLevel; i++)
            {
                health -= 1;
            }

            stamina = maxStamina;
        }

    }
}
