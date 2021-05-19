using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float movementSpeed = 10f;
    public SpawnManager spawnManager;
    public int points = 0;
    //private float xMin = -13.2f, xMax = -1.0f;
    //private float timeValue = 0.0f;
    //Vector3 playerPos = new Vector3(0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   // Antinjutut

        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;

        if (transform.position.x < -14 && hMovement < 0)
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

        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);

        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, -13.2f, -1f), transform.position.y -53f, 9999f);

        // Compute the sin position.
        //float xValue = Mathf.Sin(timeValue * 5.0f);

        // Now compute the Clamp value.
        //float xPos = Mathf.Clamp(xValue, xMin, xMax);

        // Update the position of the cube.
       // transform.position = new Vector3(xPos, -13.2f, -1f);

        // Increase animation time.
       // timeValue = timeValue + Time.deltaTime;

        // Reset the animation time if it is greater than the planned time.
       // if (xValue > Mathf.PI * 2.0f)
        
           // timeValue = 0.0f;

        }

   // public void userInput(int direction)
   // {
       // Vector3 tempPos = playerPos;
      //  switch (direction)
    //    {
         //   case 0:
        //        tempPos.y++;
       //         break;
      //      case 1:
       //         tempPos.y--;
       //         break;
       //     case 2:
       //         tempPos.x++;
       //         break;
       //     case 3:
        //        tempPos.x--;
        //        break;
      //  }
        
      //  tempPos.x = Mathf.Clamp(tempPos.y, -13.2f, -1f);

     //   playerPos = tempPos;
   // }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
     
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
    }

}
