using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HeartCollect : MonoBehaviour
{
    public int RotateSpeed;
    public GameObject ThisHeart;

    public void Update()
    {
        RotateSpeed = 2;
        transform.Rotate(0, RotateSpeed, 0, Space.World);
    }

   

    
    void OnCollisionEnter(Collision collision)
    {


        if (collision.collider.gameObject.tag != "bullet")
        {
            collision.gameObject.GetComponent<CharacterController>().points++;
            Destroy(gameObject);

            HeartSystem.HeartValue += 1;
            //ThisHeart.SetActive(false);

        }
    }
    
}
