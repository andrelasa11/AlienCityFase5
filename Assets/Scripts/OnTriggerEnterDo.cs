using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterDo : MonoBehaviour
{
    [SerializeField] private UnityEvent bulletActions;
    [SerializeField] private UnityEvent wallActions;
    [SerializeField] private UnityEvent cenarioActions;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Wall"))
        {
            wallActions.Invoke();
        }
        else if (collision.CompareTag("Cenario"))
        {
            cenarioActions.Invoke();
        }

    }

}
