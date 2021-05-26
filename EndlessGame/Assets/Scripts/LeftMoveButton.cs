using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class LeftMoveButton : MonoBehaviour, IUpdateSelectedHandler, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressed;
    float movementSpeed = 10.0f;

    // Start is called before the first frame update




    public void OnUpdateSelected(BaseEventData data)
    {
        if (isPressed)
        {
            Move();
        }
    }
    public void OnPointerDown(PointerEventData data)
    {
        isPressed = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        isPressed = false;
    }

    void Move()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
    }
}
