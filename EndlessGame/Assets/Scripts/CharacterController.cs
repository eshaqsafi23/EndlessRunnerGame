using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.EventSystems;


public class CharacterController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool buttonPressed;
    public float movementSpeed = 10f;
    public SpawnManager spawnManager;
    public int points = 0;
    public float autoMoveSpeed;
    public ParticleSystem GunFire;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    void Start()
    {
        
    }

    void Update()
    {   // Antinjutut
        // Sivuliike
        float hMovement = CrossPlatformInputManager.GetAxis("Horizontal") * movementSpeed / 2;

        if (transform.position.x < -10 && hMovement < 0)
        {
            hMovement = 0;

        }
        else if (transform.position.x > 10 && hMovement > 0)
        {
            hMovement = 0;
        }

        /* //Sivuliikkeen rajoitus
        if (transform.position.x < -14 && hMovement < 0)
        {
            hMovement = 0;

        }
        else if (transform.position.x > -1 && hMovement > 0)
        {
            hMovement = 0;
        }
        */

        // Liikuttaa pelaajaa, sivuliike GetAxis, eteenpäinliike säädetään itse autoMoveSpeed
        transform.Translate(new Vector3(hMovement, 0, autoMoveSpeed) * Time.deltaTime);


        // Antin ampuminen
        /*if (Input.GetButtonDown("Fire1"))
         {
             //Soitetaan partikkeliefekti pyssystä

             Debug.Log("PEWPEW");

             RaycastHit hit;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

             if (Physics.Raycast(ray, out hit))
             {
                 GameObject objectHit = hit.transform.gameObject; // esim. kaktus

                 // Lisäys katsotaan että rigidbody ei ole jo olemassa.
                 if (objectHit.CompareTag("Shootable") && (objectHit.GetComponent<Rigidbody>() == null))
                 {

                     Rigidbody objRB = objectHit.AddComponent<Rigidbody>();
                     objRB.mass = 0.1f;
                     Vector3 shootDirection = objectHit.transform.position - gameObject.transform.position;
                     GunFire.Play();

                     objRB.AddForceAtPosition(shootDirection, hit.point);

                 }
             }
         }*/

    }

    public void MoveLeft()
    {
        transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
    }
    public void MoveRight()
    {
        transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
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
