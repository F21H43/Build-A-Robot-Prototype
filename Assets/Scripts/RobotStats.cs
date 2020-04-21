using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotStats : MonoBehaviour
{
    public int powerProduced;
    public int powerUsed;
    private Text powerText;

    void Start()
    {
        powerText = GetComponent<Text>();
    }

    void Update()
    {
        powerText.text = "Power: " + powerUsed + " / " + powerProduced + " ziG";
    }
    
    
}
