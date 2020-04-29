using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartStats : MonoBehaviour
{
    public int powerUsage;
    public int powerProduction;
    public int weight;
    public int strength;
    public int integrity;
    public int mobility;
    public int vision;
    public int range;
    RobotStats rs;

    // Start is called before the first frame update
    void Start()
    {
        rs = FindObjectOfType<RobotStats>();
        rs.powerProduced += powerProduction;
        rs.powerUsed += powerUsage;
        rs.weight += weight;
        rs.strength += strength;
        rs.integrity += integrity;
        rs.mobility += mobility;
        rs.mobility += mobility;
        rs.vision += vision;
        rs.range += range;
    }

    private void OnDestroy()
    {
        rs.powerProduced -= powerProduction;
        rs.powerUsed -= powerUsage;
        rs.weight -= weight;
        rs.strength -= strength;
        rs.integrity -= integrity;
        rs.mobility -= mobility;
        rs.mobility -= mobility;
        rs.vision -= vision;
        rs.range -= range;
    }
}
