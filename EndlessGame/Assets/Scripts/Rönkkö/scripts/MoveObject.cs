using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float offset = 2f;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        if (transform.position.z < -20)
        {
            transform.position = new Vector3(offset, 0f, 90f);
        }
    }
}
