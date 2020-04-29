using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Symmetry : MonoBehaviour
{
    public static Transform torso;
    [SerializeField]
    GameObject leftLeg;
    [SerializeField]
    GameObject rightLeg;

    //bool to toggle on off the symmetry
    public bool symEnabled = false;

    //turns of symmetry just to be sure;
    private void Start()
    {
        ToggleSymmetry(false);
    }

    /// <summary>
    /// also the symmetry to be toggled on/off
    /// </summary>
    public void ToggleSymmetry(bool setSym)
    {
        symEnabled = setSym;
        rightLeg.transform.position = leftLeg.transform.position;
        rightLeg.SetActive(symEnabled);
        transform.position = leftLeg.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (leftLeg.GetComponent<Drag>().isHeld || Drag.selectedObj == leftLeg)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                ToggleSymmetry(!symEnabled);
            }
        }
        

        if (symEnabled)
        {
            if (leftLeg == null || rightLeg == null)
            {
                Destroy(gameObject);
            }
            if (torso != null)
            {
                if (!torso.gameObject.GetComponent<Drag>().isHeld && !leftLeg.GetComponent<Drag>().isHeld && !rightLeg.GetComponent<Drag>().isHeld)
                {
                    transform.position = torso.position;
                }
            }

            if (leftLeg.GetComponent<Drag>().isHeld)
            {
                rightLeg.transform.localPosition = new Vector3(-leftLeg.transform.localPosition.x, leftLeg.transform.localPosition.y, leftLeg.transform.localPosition.z);
                if (leftLeg.GetComponent<Drag>().isRotating != 0)
                {
                    rightLeg.GetComponent<Drag>().RotatePart(-leftLeg.GetComponent<Drag>().isRotating);
                }
                rightLeg.transform.localScale = leftLeg.transform.localScale;
            }

            if (rightLeg.GetComponent<Drag>().isHeld)
            {
                leftLeg.transform.localPosition = new Vector3(-rightLeg.transform.localPosition.x, rightLeg.transform.localPosition.y, rightLeg.transform.localPosition.z);
                if (rightLeg.GetComponent<Drag>().isRotating != 0)
                {
                    leftLeg.GetComponent<Drag>().RotatePart(-rightLeg.GetComponent<Drag>().isRotating);
                }
            }
            leftLeg.transform.localScale = rightLeg.transform.localScale;
        }
    }
}
