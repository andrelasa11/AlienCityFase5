using UnityEngine;
using UnityEngine.Events;

public class HealthController : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private float maxLife;
    [SerializeField] private float currentLife;
    [SerializeField] private UnityEvent onZeroHealthPointsActions;

    [Header("Dependencies")]
    [SerializeField] private HudController hudController;

    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;

        if(hudController != null)
        {
            hudController.SetMaxHealthBar(maxLife);
            hudController.SetHealthBar(currentLife);
        }
        
    }

    public void OnDamage(float damage)
    {
        currentLife -= damage;

        if(hudController != null)
        {
            hudController.SetHealthBar(currentLife);
        }        

        if (currentLife <= 0)
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
