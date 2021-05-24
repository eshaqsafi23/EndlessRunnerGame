[1mdiff --cc EndlessGame/Assets/Scripts/CharacterController.cs[m
[1mindex 80caa56,7dea7dd..0000000[m
[1m--- a/EndlessGame/Assets/Scripts/CharacterController.cs[m
[1m+++ b/EndlessGame/Assets/Scripts/CharacterController.cs[m
[36m@@@ -1,75 -1,72 +1,120 @@@[m
  ﻿using System.Collections;[m
  using System.Collections.Generic;[m
  using UnityEngine;[m
[32m++<<<<<<< HEAD[m
[32m++=======[m
[32m+ [m
[32m++>>>>>>> parent of f84d20d (Imported Assets)[m
  [m
  public class CharacterController : MonoBehaviour[m
  {[m
      public float movementSpeed = 10f;[m
      public SpawnManager spawnManager;[m
      public int points = 0;[m
[32m++<<<<<<< HEAD[m
[32m +    //private float xMin = -13.2f, xMax = -1.0f;[m
[32m +    //private float timeValue = 0.0f;[m
[32m +    //Vector3 playerPos = new Vector3(0, 0);[m
[32m++=======[m
[32m+     public float autoMoveSpeed;[m
[32m+     public ParticleSystem GunFire;[m
[32m++>>>>>>> parent of f84d20d (Imported Assets)[m
  [m
[32m +    // Start is called before the first frame update[m
      void Start()[m
      {[m
          [m
      }[m
  [m
[32m +    // Update is called once per frame[m
      void Update()[m
[32m++<<<<<<< HEAD[m
[32m +    {[m
[32m +        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;[m
[32m +        float vMovement = Input.GetAxis("Vertical") * movementSpeed;[m
[32m++=======[m
[32m+     {   // Antinjutut[m
[32m+         // Sivuliike[m
[32m+         float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;[m
[32m+        [m
[32m+         //crossplatform[m
[32m+         [m
[32m+         //Sivuliikkeen rajoitus[m
[32m+         if (transform.position.x < -14 && hMovement < 0)[m
[32m+         {[m
[32m+             hMovement = 0;[m
[32m+ [m
[32m+         }[m
[32m+         else if (transform.position.x > -1 && hMovement > 0)[m
[32m+         {[m
[32m+             hMovement = 0;[m
[32m+         }[m
[32m++>>>>>>> parent of f84d20d (Imported Assets)[m
  [m
[31m -        // Liikuttaa pelaajaa, sivuliike GetAxis, eteenpäinliike säädetään itse autoMoveSpeed[m
[31m -        transform.Translate(new Vector3(hMovement, 0, autoMoveSpeed) * Time.deltaTime);[m
[32m +        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);[m
  [m
[32m++<<<<<<< HEAD[m
[32m +        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, -13.2f, -1f), transform.position.y -53f, 9999f);[m
[32m++=======[m
[32m+ [m
[32m+         // Antin ampuminen[m
[32m+         if (Input.GetButtonDown("Fire1"))[m
[32m+         {[m
[32m+                  //Soitetaan partikkeliefekti pyssystä[m
[32m+                   GunFire.Play();[m
[32m++>>>>>>> parent of f84d20d (Imported Assets)[m
[32m +[m
[32m +        // Compute the sin position.[m
[32m +        //float xValue = Mathf.Sin(timeValue * 5.0f);[m
[32m +[m
[32m +        // Now compute the Clamp value.[m
[32m +        //float xPos = Mathf.Clamp(xValue, xMin, xMax);[m
  [m
[31m -            RaycastHit hit;[m
[31m -            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);[m
[32m +        // Update the position of the cube.[m
[32m +       // transform.position = new Vector3(xPos, -13.2f, -1f);[m
  [m
[31m -            if (Physics.Raycast(ray, out hit))[m
[31m -            {[m
[31m -                GameObject objectHit = hit.transform.gameObject; // esim. kaktus[m
[32m +        // Increase animation time.[m
[32m +       // timeValue = timeValue + Time.deltaTime;[m
  [m
[31m -                // Lisäys katsotaan että rigidbody ei ole jo olemassa.[m
[31m -                if (objectHit.CompareTag("Shootable") && (objectHit.GetComponent<Rigidbody>() == null))[m
[31m -                {[m
[32m +        // Reset the animation time if it is greater than the planned time.[m
[32m +       // if (xValue > Mathf.PI * 2.0f)[m
[32m +        [m
[32m +           // timeValue = 0.0f;[m
[32m +[m
[32m++<<<<<<< HEAD[m
[32m +        }[m
  [m
[31mwarning: LF will be replaced by CRLF in EndlessGame/ProjectSettings/ProjectSettings.asset.
The file will have its original line endings in your working directory
 -                    Rigidbody objRB = objectHit.AddComponent<Rigidbody>();[m
[31m -                    objRB.mass = 0.1f;[m
[31m -                    Vector3 shootDirection = objectHit.transform.position - gameObject.transform.position;[m
[32m +   // public void userInput(int direction)[m
[32m +   // {[m
[32m +       // Vector3 tempPos = playerPos;[m
[32m +      //  switch (direction)[m
[32m +    //    {[m
[32m +         //   case 0:[m
[32m +        //        tempPos.y++;[m
[32m +       //         break;[m
[32m +      //      case 1:[m
[32m +       //         tempPos.y--;[m
[32m +       //         break;[m
[32m +       //     case 2:[m
[32m +       //         tempPos.x++;[m
[32m +       //         break;[m
[32m +       //     case 3:[m
[32m +        //        tempPos.x--;[m
[32m +        //        break;[m
[32m +      //  }[m
[32m +        [m
[32m +      //  tempPos.x = Mathf.Clamp(tempPos.y, -13.2f, -1f);[m
  [m
[31m -                    [m
[31m -                    objRB.AddForceAtPosition(shootDirection, hit.point);[m
[32m +     //   playerPos = tempPos;[m
[32m +   // }[m
  [m
[32m++=======[m
[32m+                 }[m
[32m+             }[m
[32m+         }[m
[32m+     }[m
[32m+        [m
[32m++>>>>>>> parent of f84d20d (Imported Assets)[m
      private void OnTriggerEnter(Collider other)[m
      {[m
          spawnManager.SpawnTriggerEntered();[m
[1mdiff --git a/EndlessGame/ProjectSettings/ProjectSettings.asset b/EndlessGame/ProjectSettings/ProjectSettings.asset[m
[1mindex 29c3b85..5100cf0 100644[m
[1m--- a/EndlessGame/ProjectSettings/ProjectSettings.asset[m
[1m+++ b/EndlessGame/ProjectSettings/ProjectSettings.asset[m
[36m@@ -580,7 +580,11 @@[m [mPlayerSettings:[m
   webGLLinkerTarget: 1[m
   webGLThreadsSupport: 0[m
   webGLDecompressionFallback: 0[m
[31m-  scriptingDefineSymbols: {}[m
[32m+[m[32m  scriptingDefineSymbols:[m
[32m+[m[32m    1: CROSS_PLATFORM_INPUT[m
[32m+[m[32m    4: CROSS_PLATFORM_INPUT;MOBILE_INPUT[m
[32m+[m[32m    7: CROSS_PLATFORM_INPUT;MOBILE_INPUT[m
[32m+[m[32m    14: MOBILE_INPUT[m
   platformArchitecture: {}[m
   scriptingBackend: {}[m
   il2cppCompilerConfiguration: {}[m
