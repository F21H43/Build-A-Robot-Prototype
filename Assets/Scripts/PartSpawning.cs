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
        }       
    }

    public void SpawnRoboPart(GameObject part)
    {
        Instantiate(part, Vector3.right * 5, Quaternion.identity);
    }
}
