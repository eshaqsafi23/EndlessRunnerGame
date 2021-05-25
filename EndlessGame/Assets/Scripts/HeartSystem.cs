using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life = 3;
   // public int maxlife = 3;
    public Transform PlayerPrefab;
    public GameObject Heart0;
    public GameObject Heart1;
    public GameObject Heart2;
    public static int HeartValue ;

     public void Start()
     {
        HeartValue = 1;
     }
    void Update()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
        }
        else if (life < 2) 
        {
            Destroy(hearts[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject);
        }
    }

    public void TakeDamage(int d)
    {
        life -= d;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
       
       if (life <= 0)
          Destroy(GameObject.FindGameObjectWithTag("Player"));

        if (life == 0)
        {
            SceneManager.LoadScene("SampleScene");

        }

        // if (GameObject.FindGameObjectWithTag("Player") == null)
        //       Instantiate(PlayerPrefab, GameObject.Find("PlayerSpawnPoint").transform.position, Quaternion.identity);
        //  life = maxlife;

    }
}
