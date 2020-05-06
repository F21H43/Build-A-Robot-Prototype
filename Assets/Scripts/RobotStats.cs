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

        if(weight >= 5)
        {
            weightText.text = "WGT: 5";
        }
        else if(weight <= -5)
        {
            weightText.text = "WGT: -5";
        }
        else
        {
            weightText.text = "WGT: " + weight;
        }
        
        if (strength >= 5)
        {
            strengthText.text = "STR: 5";
        }
        else if (strength <= -5)
        {
            strengthText.text = "STR: -5";
        }
        else
        {
            strengthText.text = "STR: " + strength;
        }
        
        if (integrity >= 5)
        {
            integrityText.text = "INTGR: 5";
        }
        else if (integrity <= -5)
        {
            integrityText.text = "INTGR: -5";
        }
        else
        {
            integrityText.text = "INTGR: " + integrity;
        }  
        
        if (mobility >= 5)
        {
            mobilityText.text = "MOB: 5";
        }
        else if (mobility <= -5)
        {
            mobilityText.text = "MOB: -5";
        }
        else
        {
            mobilityText.text = "MOB: " + mobility;
        }
        
        if (vision >= 5)
        {
            visionText.text = "VIS: 5";
        }
        else if (vision <= -5)
        {
            visionText.text = "VIS: -5";
        }
        else
        {
            visionText.text = "VIS: " + vision;
        }
        
        if (range >= 5)
        {
            rangeText.text = "RNG: 5";
        }
        else if (range <= -5)
        {
            rangeText.text = "RNG: -5";
        }
        else
        {
            rangeText.text = "RNG: " + range;
        }
    }
    
    
}
