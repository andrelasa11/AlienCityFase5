using UnityEngine;

public class Rotator : MonoBehaviour
{

    [Header("Configuration")]
    public float speedRotation;
    public bool xRotation = false;
    public bool yRotation = false;
    public bool zRotation = false;

    void FixedUpdate()
    {
        if(xRotation)
        {
            transform.Rotate(new Vector3(speedRotation, 0, 0) * Time.deltaTime);
        }
        if(yRotation)
        {
            transform.Rotate(new Vector3(0, speedRotation, 0) * Time.deltaTime);
        }
        if(zRotation)
        {
            transform.Rotate(new Vector3(0, 0, speedRotation) * Time.deltaTime);
        }
        if(xRotation && yRotation)
        {
            transform.Rotate(new Vector3(speedRotation, speedRotation, 0) * Time.deltaTime);
        }
        if(xRotation && zRotation)
        {
            transform.Rotate(new Vector3(speedRotation, 0, speedRotation) * Time.deltaTime);
        }
        if(yRotation && zRotation)
        {
            transform.Rotate(new Vector3(0, speedRotation, speedRotation) * Time.deltaTime);
        }
        if(xRotation && yRotation && zRotation)
        {
            transform.Rotate(new Vector3(speedRotation, speedRotation, speedRotation) * Time.deltaTime);
        }
        
    }
}
