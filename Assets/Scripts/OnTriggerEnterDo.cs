using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterDo : MonoBehaviour
{
    [SerializeField] private UnityEvent playerActions;
    [SerializeField] private UnityEvent bulletActions;
    [SerializeField] private UnityEvent wallActions;
    [SerializeField] private UnityEvent stoneActions;
    [SerializeField] private UnityEvent keyAActions;
    [SerializeField] private UnityEvent keyBActions;
    [SerializeField] private UnityEvent cenarioActions;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerActions.Invoke();
        }
        else if(collision.CompareTag("Wall"))
        {
            wallActions.Invoke();
        }
        else if (collision.CompareTag("Cenario"))
        {
            cenarioActions.Invoke();
        }
        else if (collision.CompareTag("Stone"))
        {
            stoneActions.Invoke();
        }
        else if (collision.CompareTag("KeyA"))
        {
            keyAActions.Invoke();
        }
        else if (collision.CompareTag("KeyB"))
        {
            keyBActions.Invoke();
        }

    }

}
