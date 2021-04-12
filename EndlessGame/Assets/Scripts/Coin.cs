using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
            transform.Rotate(0, 90 * Time.deltaTime, 0);

        

    }
    void OnCollisionEnter(Collision collision)
    {
        
        
        if (collision.collider.gameObject.tag != "bullet")
        {
            collision.gameObject.GetComponent<CharacterController>().points++;
            Destroy(gameObject);

        }
    }



}
