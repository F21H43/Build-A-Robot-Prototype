﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitAndFinishController : MonoBehaviour
{
    //UI that needs to shown on the finish screen
    public List<GameObject> finishUI;

    //UI that needs to be disabled for the finish screen
    public List<GameObject> disableUI;

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
        ChangeUI();
        EvaluateRobot();
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
        Debug.Log("Evaluation here");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
