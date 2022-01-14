using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health;
    public float power;
    public float armor;

    public float Shoot()
    {
        return power;
    }

    public void GetDamage(float damage)
    {
        if (armor > 0)
        {
            armor -= damage;
        }
        else
        {
            this.health -= damage;
        }
    }

}
