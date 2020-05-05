using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotStats : MonoBehaviour
{
    public int powerProduced;
    public int powerUsed;
    public int weight;
    public int strength;
    public int integrity;
    public int mobility;
    public int vision;
    public int range;

    private Text powerText;

    public Text weightText;
    public Text strengthText;
    public Text integrityText;
    public Text mobilityText;
    public Text visionText;
    public Text rangeText;

    void Start()
    {
        powerText = GetComponent<Text>();
    }

    void Update()
    {
        powerText.text = "Power: " + powerUsed + " / " + powerProduced;
        weightText.text = "WGT: " + weight;
        strengthText.text = "STR: " + strength;
        integrityText.text = "INTGR: " + integrity;
        mobilityText.text = "MOB: " + mobility;
        visionText.text = "VIS: " + vision;
        rangeText.text = "RNG: " + range;
    }
    
    
}
