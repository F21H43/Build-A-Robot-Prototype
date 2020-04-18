using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoreInfoPanelController : MonoBehaviour
{
    public GameObject panel;
    public Text nameText;
    public Image partImage;
    public Text powerText;
    public Text partDescription;
    public Button closePanel;

    public void OpenMoreInfoPanel()
    {
        panel.SetActive(true);
    }

    public void CloseMoreInfoPanel()
    {
        panel.SetActive(false);
    }

    public void SetName(string name)
    {
        nameText.text = name;
    }

    public void SetImage(Sprite image)
    {
        partImage.sprite = image;
    }

    public void SetPowerText(string text)
    {
        powerText.text = text;
    }

    public void SetPartDescription(string description)
    {
        partDescription.text = description;
    }
}
