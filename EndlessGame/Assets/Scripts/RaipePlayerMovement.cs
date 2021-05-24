using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaipePlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier = 2;

    private void FixedUpdate ()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime * horizontalMultiplier;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}
