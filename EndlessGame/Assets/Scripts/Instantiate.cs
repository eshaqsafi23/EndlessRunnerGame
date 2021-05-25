using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public Transform prefab;

    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(Random.Range(0.1f, 1.3f));
            Instantiate(prefab, new Vector3(
                transform.position.x + Random.Range(-2f, 2f),
                transform.position.y,
                transform.position.z),
                Quaternion.Euler(0f, 0f, 0f));
        }

    }
}