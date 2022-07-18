using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Configuration")]
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpHeight;

    [Header("GroundCheck Configuration")]
    [SerializeField] private float groundDistance = 0.4f;
    [SerializeField] private LayerMask groundMask;

    [Header("Shoot Configuration")]
    [SerializeField] private float fireRate;
    [SerializeField] private GameObject shootPrefab;
    [SerializeField] private Transform shootOrigin;

    [Header("Dependencies")]
    [SerializeField] private Transform playerBody;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private Animator animator;

    //private
    private float gravity = -30f;
    private Vector3 velocity;
    private bool isGrounded;
    private float nextShoot;

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        
        #region "Rotation"

        float horizontalRotation = Input.GetAxis("Horizontal");
        playerBody.Rotate(Vector3.up * horizontalRotation * rotationSpeed * Time.deltaTime);

        #endregion

        #region "Foward/Backward Movement"

        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.forward * z;

        characterController.Move(move * movementSpeed * Time.deltaTime);

        if (z != 0 && isGrounded)
        {
            animator.SetBool("IsRunning", true);
        }
        else animator.SetBool("IsRunning", false);

        if(isGrounded == false)
        {
            animator.SetBool("IsRunning", false);
        }

        #endregion

        #region "Jumping"

        if (Input.GetButtonDown("Jump") && isGrounded)
        {            
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            animator.SetTrigger("Jump!");
        }

        #endregion

        #region "Gravity"

        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);

        #endregion

        #region "Shooting"

        if (Input.GetButtonDown("Fire1") && Time.time > nextShoot)
        {
            nextShoot = Time.time + fireRate;
            Instantiate(shootPrefab, shootOrigin.position, shootOrigin.rotation);
        }

        #endregion

    }


}
