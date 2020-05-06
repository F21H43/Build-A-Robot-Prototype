using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public bool arm;
    public bool leg;

    public string description;

    // Start is called before the first frame update
    void Start()
    {
        //rs = FindObjectOfType<RobotStats>();
        //rs.powerProduced += powerProduction;
        //rs.powerUsed += powerUsage;
        //rs.weight += weight;
        //rs.strength += strength;
        //rs.integrity += integrity;
        //rs.mobility += mobility;
        //rs.mobility += mobility;
        //rs.vision += vision;
        //rs.range += range;
    }

    private void OnEnable()
    {
        RobotStats.powerProduced += powerProduction;
        RobotStats.powerUsed += powerUsage;
        RobotStats.weight += weight;
        RobotStats.strength += strength;
        RobotStats.integrity += integrity;
        RobotStats.mobility += mobility;
        RobotStats.vision += vision;
        RobotStats.range += range;
        if (arm)
        {
            RobotStats.arms++;
        }
        if (leg)
        {
            RobotStats.legs++;
        }
    }

    private void OnDestroy()
    {
        //rs.powerProduced -= powerProduction;
        //rs.powerUsed -= powerUsage;
        //rs.weight -= weight;
        //rs.strength -= strength;
        //rs.integrity -= integrity;
        //rs.mobility -= mobility;
        //rs.mobility -= mobility;
        //rs.vision -= vision;
        //rs.range -= range;
    }

    private void OnDisable()
    {
        RobotStats.powerProduced -= powerProduction;
        RobotStats.powerUsed -= powerUsage;
        RobotStats.weight -= weight;
        RobotStats.strength -= strength;
        RobotStats.integrity -= integrity;
        RobotStats.mobility -= mobility;
        RobotStats.vision -= vision;
        RobotStats.range -= range;
        if (arm)
        {
            RobotStats.arms--;
        }
        if (leg)
        {
            RobotStats.legs--;
        }
    }
}
