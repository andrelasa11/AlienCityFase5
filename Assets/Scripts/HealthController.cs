using UnityEngine;
using UnityEngine.Events;

public class HealthController : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private float maxLife;
    [SerializeField] private float currentLife;
    [SerializeField] private UnityEvent onZeroHealthPointsActions;

    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;
    }

    public void OnDamage(float damage)
    {
        currentLife -= damage;

        if(currentLife <= 0)
        {
            OnZeroHealthPoints();
        }
    }

    public void OnZeroHealthPoints()
    {
        if (onZeroHealthPointsActions != null)
        {
            onZeroHealthPointsActions.Invoke();
        }
    }


}
