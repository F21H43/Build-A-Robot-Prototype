using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOverStuff : MonoBehaviour
{
    public GameObject mouseOverPanel;
    public Text mouseOverText1;
    public Text mouseOverText2;
    public Text mouseOverText3;
    public Text mouseOverText4;
    public Text mouseOverText5;
    public Text mouseOverText6;
    public Text mouseOverText7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnMouseOver(GameObject part)
    {
        mouseOverPanel.SetActive(true);
        if(part.GetComponent<PartStats>().powerProduction.ToString() != "0")
        {
            mouseOverText1.text = "Power Capacity: " + part.GetComponent<PartStats>().powerProduction.ToString();
        }
        else
        {
            mouseOverText1.text = "Power Cost: " + part.GetComponent<PartStats>().powerUsage.ToString();
        }
        
        mouseOverText2.text = "Weight: " + part.GetComponent<PartStats>().weight.ToString();
        mouseOverText3.text = "Strenght: " + part.GetComponent<PartStats>().strength.ToString();
        mouseOverText4.text = "Integrity: " + part.GetComponent<PartStats>().integrity.ToString();
        mouseOverText5.text = "Mobility: " + part.GetComponent<PartStats>().mobility.ToString();
        mouseOverText6.text = "Vision: " + part.GetComponent<PartStats>().vision.ToString();
        mouseOverText7.text = "Range: " + part.GetComponent<PartStats>().range.ToString();
    }

    public void DeleteMouseOver()
    {
        mouseOverPanel.SetActive(false);
    }
}
