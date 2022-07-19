using UnityEngine;

public abstract class Trap : MonoBehaviour
{
    [SerializeField] protected float damage;
    [SerializeField] protected float cadence;
    
    protected float nextDamage;
    

    public virtual void DoDamage(Collider collision)
    {
        
    }
}
