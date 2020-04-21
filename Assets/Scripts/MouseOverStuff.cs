using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOverStuff : MonoBehaviour
{
    public GameObject mouseOverPanel;
    public Text mouseOverPanelText;
    public Text mouseOverDescription;
    public string powerDisplay;
    public string descriptionDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnMouseOver()
    {
        mouseOverPanel.SetActive(true);
        mouseOverPanelText.text = powerDisplay;
        mouseOverDescription.text = descriptionDisplay;
    }

    public void DeleteMouseOver()
    {
        mouseOverPanel.SetActive(false);
    }
}
