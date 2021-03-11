using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody myRB;
    public float moveSpeed;
    public float rotateSpeed;
    public float jumpForce;

    void Start()
    {
        myRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zMovement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(xMovement, 0, zMovement);

        float mouseInput = Input.GetAxis("Mouse X");
        Vector3 lookHere = new Vector3(0, mouseInput * rotateSpeed * Time.deltaTime, 0);
        transform.Rotate(lookHere);



        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }


}




