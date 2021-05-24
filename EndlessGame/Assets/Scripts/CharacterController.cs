using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterController : MonoBehaviour
{
    public float movementSpeed = 10f;
    public SpawnManager spawnManager;
    public int points = 0;


    public float autoMoveSpeed;
    public ParticleSystem GunFire;



    void Start()
    {
        
    }


    void Update()

    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;

    {   // Antinjutut
        // Sivuliike
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
       
        //crossplatform
        
        //Sivuliikkeen rajoitus
        if (transform.position.x < -14 && hMovement < 0)
        {
            hMovement = 0;

        }
        else if (transform.position.x > -1 && hMovement > 0)
        {
            hMovement = 0;
        }


        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);



        // Antin ampuminen
        if (Input.GetButtonDown("Fire1"))
        {
                 //Soitetaan partikkeliefekti pyssystä
                  GunFire.Play();


        }

  
                }
            }
        }
    }
       

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
     
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
    }

}
