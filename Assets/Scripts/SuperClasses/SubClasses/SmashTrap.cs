using UnityEngine;

public class SmashTrap : Trap
{
    public override void DoDamage(Collider collision)
    {
        Debug.Log("Colidindo");
        HealthController characterLife = collision.GetComponent<HealthController>();

        if (characterLife != null)
        {
            characterLife.OnDamage(damage);
        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        DoDamage(collision);
    }
}
