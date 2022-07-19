using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThornTrap : Trap
{
    public override void DoDamage(Collider collision)
    {
        Debug.Log("Colidindo");
        HealthController characterLife = collision.GetComponent<HealthController>();

        if (characterLife != null && Time.time > nextDamage)
        {
            nextDamage = Time.time + cadence;
            characterLife.OnDamage(damage);
        }

    }

    private void OnTriggerStay(Collider collision)
    {
        DoDamage(collision);

    }
}
