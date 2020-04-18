using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    public static float rotationAmount = 1f;
    public bool isHeld;

    private void Update()
    {
        if (transform.position.x < 0 && !isHeld)
        {
            if (this.gameObject.layer == 8)
            {
                PartSpawning.torsoSpawned = false;
            }
            Destroy(this.gameObject);
        }
    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        isHeld = true;
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, 1), -rotationAmount);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, 1), rotationAmount);
        }
    }

    private void OnMouseUp()
    {
        isHeld = false;
    }
}
