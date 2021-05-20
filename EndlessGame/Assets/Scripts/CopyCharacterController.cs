using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyCharacterController : MonoBehaviour
{
    public float movementSpeed = 10f;
    public SpawnManager spawnManager;
    public int points = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;

        if (transform.position.x < -13.2 && hMovement < 0)
        {
            hMovement = 0;

        }
        else if (transform.position.x > -1 && hMovement > 0)
        {
            hMovement = 0;
        }

        

        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);

        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                GameObject objectHit = hit.transform.gameObject; // esim. kaktus
                if (objectHit.CompareTag("Shootable"))
                {
                    Rigidbody objRB = objectHit.AddComponent<Rigidbody>();
                    objRB.mass = 0.1f;
                    Vector3 shootDirection = objectHit.transform.position - gameObject.transform.position;

                    objRB.AddForceAtPosition(shootDirection, hit.point);
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

