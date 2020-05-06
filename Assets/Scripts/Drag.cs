using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    //how fast you rotate
    public static float rotationAmount = 5f;
    public bool isHeld;
    public static GameObject selectedObj;
    [SerializeField]
    private bool canRotate = true;
    //0 is not rotating -1 is rotating left, 1 rotating right this should never be geater than +1/-1
    public int isRotating = 0;
    SpriteRenderer sprite;

    private void Start()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        sprite = GetComponentInParent<SpriteRenderer>();
    }

    private void Update()
    {
        FollowMouseCursor();
        //destroys the part if it's too far to the left
        if (transform.position.x < 0 && !isHeld)
        {
            if (this.gameObject.layer == 8)
            {
                PartSpawning.torsoSpawned = false;
            }
            Destroy(this.gameObject);
        }
        //makes the part not held if the part left up
        if(Input.GetMouseButtonUp(0) && isHeld)
        {
            isHeld = false;
        }

        if(selectedObj == this.gameObject)
        {
            sprite.color = Color.cyan;
            if (Input.GetKey(KeyCode.E))
            {
                isRotating = -1;
                RotatePart(isRotating);
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                isRotating = 1;
                RotatePart(isRotating);
            }
            else
            {
                isRotating = 0;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            }
        }else
        {
            sprite.color = Color.white;
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
        selectedObj = gameObject;
    }

    /// <summary>
    /// the parts follows the cursor if held
    /// </summary>
    private void FollowMouseCursor()
    {
        if (isHeld)
        {
            Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
            transform.position = cursorPosition;
        }
    }

    /// <summary>
    /// rotates a part
    /// directions: 0 is not rotating; -1 is rotating left; 1 rotating right; this should never be geater than +1/-1
    /// </summary>
    /// <param name="direction"></param>
    public void RotatePart(int direction)
    {
        transform.Rotate(new Vector3(0, 0, 1), rotationAmount*direction);
    }
}
