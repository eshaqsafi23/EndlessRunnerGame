using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCollectible : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    void Start()
    {
        Destroy(gameObject, 20f);
    }

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
    }
}