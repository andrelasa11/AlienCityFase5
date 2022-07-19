using UnityEngine;

public class KeyController : MonoBehaviour
{
    public bool hasKeyA = false;
    public bool hasKeyB = false;

    public void SetKeyA()
    {
        hasKeyA = true;
    }

    public void SetKeyB()
    {
        hasKeyB = true;
    }
}
