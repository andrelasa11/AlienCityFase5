using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamage : MonoBehaviour
{
    public float damage;

    private void OnTriggerEnter(Collider collision)
    {
        HealthController characterLife = collision.GetComponent<HealthController>();

        if (characterLife != null)
        {
            characterLife.OnDamage(damage);
        }

    }

}