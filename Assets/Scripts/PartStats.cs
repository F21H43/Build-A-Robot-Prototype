using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartStats : MonoBehaviour
{
    public int powerUsage;
    public int powerProduction;
    RobotStats rs;

    // Start is called before the first frame update
    void Start()
    {
        rs = FindObjectOfType<RobotStats>();
        rs.powerProduced += powerProduction;
        rs.powerUsed += powerUsage;
    }

    private void OnDestroy()
    {
        rs.powerProduced -= powerProduction;
        rs.powerUsed -= powerUsage;
    }
}
