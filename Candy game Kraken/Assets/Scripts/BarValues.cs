using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarValues : MonoBehaviour
{
    public HealthBar Bar;
    public HealthBar energyBar;
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
            //Debug.Log("collide with candy");
            stamina += 100/addictionLevel;
        }

        if (target.gameObject.tag == "Vegetable")
        {
            addictionLevel--;
            health += 10;
            stamina += 10;
        }
    }

    void Start()
    {
        stamina = maxStamina;
    }

    void Update()
    {
        energyBar.SetEnergy(Mathf.RoundToInt(stamina));

        Bar.SetHealth(health);

        stamina -= Time.deltaTime * addictionLevel;

        /*if (health < 1)
        {
            SceneManager.LoadScene(2);
        }*/

        if (addictionLevel < 0)
        {
            addictionLevel = 0;
        }

        if (stamina < 1)
        {
            for (int i = 0; i < addictionLevel; i++)
            {
                health -= 1;
            }

            stamina = maxStamina;
        }

        if (stamina > maxStamina)
        {
            stamina = maxStamina;
        }
    }
}
