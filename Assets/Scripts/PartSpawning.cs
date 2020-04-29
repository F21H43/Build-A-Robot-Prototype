using System.Collections;
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
            GameObject newTorso = Instantiate(torso, Vector3.right * 5, Quaternion.identity);
            torsoSpawned = true;
            Symmetry.torso = newTorso.transform;
            Drag.selectedObj = newTorso;
        }       
    }

    public void SpawnRoboPart(GameObject part)
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        GameObject newPart = Instantiate(part, mousePos, Quaternion.identity);
        if(newPart.GetComponent<Drag>() != null)
        {
            Drag.selectedObj = newPart;
        } else if(newPart.GetComponentInChildren<Drag>() != null)
        {
            Drag.selectedObj = newPart.GetComponentInChildren<Drag>().gameObject;
        }
    }
}
