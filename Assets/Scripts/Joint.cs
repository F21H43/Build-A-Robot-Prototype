﻿using System.Collections;
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

    private void Update()
    {
        if (connected)
        {
            sprite.color = Color.white;
        } else
        {
            sprite.color = Color.red;
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BodySegment"))
        {
            Debug.Log("Connected body segment");
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