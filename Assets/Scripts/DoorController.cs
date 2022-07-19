using UnityEngine;

public class DoorController : MonoBehaviour
{

    [SerializeField] private KeyController keyController;
    [SerializeField] private Animator animator;

    public void OpenDoor()
    {
        if (keyController.hasKeyA && keyController.hasKeyB)
        {
            animator.SetTrigger("Open");
        }
    }

}
