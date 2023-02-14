using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Variables
    Rigidbody rb;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        // Variables for Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Movement Script
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x, 5f, rb.velocity.z);
        }
        if (Input.GetKey("up"))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 5f);
        }
        if (Input.GetKey("right"))
        {
            rb.velocity = new Vector3(5f, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKey("down"))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -5f);
        }
        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector3(-5f, rb.velocity.y, rb.velocity.z);
        }
    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
    
}
