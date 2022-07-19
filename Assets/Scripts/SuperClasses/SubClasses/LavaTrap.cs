using UnityEngine;

public class LavaTrap : Trap
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
