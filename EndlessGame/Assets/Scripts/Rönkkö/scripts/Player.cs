using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    private float runSpeed = 2.0f;
    public Rigidbody rb;

    float distanceToGround;

    private void Start()
    {
        distanceToGround = GetComponent<BoxCollider>().extents.y;
    }
    void Update()
    {
        if (!isGrounded())
            return;


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate((Vector3.left * Time.deltaTime * moveSpeed) * runSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate((Vector3.right * Time.deltaTime * moveSpeed) * runSpeed);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            runSpeed = 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            runSpeed = 1;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * 380.0f);
        }
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2f, 2f),
            transform.position.y,
            0);


    }

    public bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, distanceToGround);
    }
}
