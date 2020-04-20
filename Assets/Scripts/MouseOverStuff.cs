using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOverStuff : MonoBehaviour
{
    public GameObject mouseOverPanel;
    public Text mouseOverPanelText;
    public string powerDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseOverPanel.transform.position = Input.mousePosition;
    }

    public void SpawnMouseOver()
    {
        mouseOverPanel.SetActive(true);
        mouseOverPanelText.text = powerDisplay;
    }

    public void DeleteMouseOver()
    {
        mouseOverPanel.SetActive(false);
    }
}
