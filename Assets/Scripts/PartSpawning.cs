﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartSpawning : MonoBehaviour
{
    public static bool torsoSpawned = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTorso(GameObject torso)
    {
        if (!torsoSpawned)
        {
            Instantiate(torso, Vector3.right * 5, Quaternion.identity);
            torsoSpawned = true;
        }       
    }

    public void SpawnRoboPart(GameObject part)
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Instantiate(part, mousePos, Quaternion.identity);
    }
}
