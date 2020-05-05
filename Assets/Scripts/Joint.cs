using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joint : MonoBehaviour
{
    SpriteRenderer sprite;
    private bool connected = false;

    private void Start()
    {
        sprite = GetComponentInParent<SpriteRenderer>();
    }


    /// <summary>
    /// if we are connected make the 
    /// </summary>
    private void Update()
    {
        if(Drag.selectedObj != gameObject.transform.parent.gameObject)
        {
            if (connected)
            {
                sprite.color = Color.white;
            }
            else
            {
                sprite.color = Color.red;
            }
        } else if(!connected)
        {
            sprite.color = Color.magenta;
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BodySegment"))
        {
            connected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BodySegment"))
        {
            connected = false;
        }
    }
}
