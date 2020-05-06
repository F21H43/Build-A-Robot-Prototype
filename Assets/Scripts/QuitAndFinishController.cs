using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitAndFinishController : MonoBehaviour
{
    //UI that needs to shown on the finish screen
    public List<GameObject> finishUI;

    //UI that needs to be disabled for the finish screen
    public List<GameObject> disableUI;

    public GameObject powerPopup;

    public Text finishText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

    public void FinishBuildingRobot()
    {
        if (CheckRobotPower())
        {
            ChangeUI();
            EvaluateRobot();
        }
        else
        {
            NotEnoughPowerPopup();
        }
    }

    void ChangeUI()
    {
        foreach(GameObject ui in finishUI)
        {
            ui.SetActive(true);
        }

        foreach(GameObject ui in disableUI)
        {
            ui.SetActive(false);
        }

        Drag[] parts = FindObjectsOfType<Drag>();

        foreach(Drag part in parts)
        {
            part.enabled = false;
        }

        Camera.main.transform.position = Vector3.zero + (Vector3.right * 5) + (Vector3.back * 10);
    }

    void EvaluateRobot()
    {
        if(RobotStats.range >= 3 && RobotStats.mobility >= 1 && RobotStats.strength >= 2  && RobotStats.vision >= 1)
        {
            finishText.text = "Looks like this will work, Good Job!";
        }
        else if (!PartSpawning.torsoSpawned)
        {
            finishText.text = "...really?";
        }
        else
        {
            finishText.text = "Looks like you're missing a few things...";
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    bool CheckRobotPower()
    {
        return RobotStats.powerProduced >= RobotStats.powerUsed;
    }

    void NotEnoughPowerPopup()
    {
        powerPopup.SetActive(true);
    }

    public void DisablePopup()
    {
        powerPopup.SetActive(false);
    }
}
