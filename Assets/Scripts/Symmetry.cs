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
    [SerializeField]
    Vector3 startPos = new Vector3(4, 1, 0);

    //bool to toggle on off the symmetry
    public bool symEnabled = false;

    //turns of symmetry just to be sure;
    private void Start()
    {
        ToggleSymmetry(false);
        transform.position = startPos;
    }

    /// <summary>
    /// also the symmetry to be toggled on/off
    /// </summary>
    public void ToggleSymmetry(bool setSym)
    {
        symEnabled = setSym;
        if(Drag.selectedObj == rightLeg)
        {
            leftLeg.transform.localPosition = new Vector3(-rightLeg.transform.localPosition.x, rightLeg.transform.localPosition.y, rightLeg.transform.localPosition.z);
            leftLeg.SetActive(symEnabled);
        } else if (Drag.selectedObj == leftLeg){
            rightLeg.transform.localPosition = new Vector3(-leftLeg.transform.localPosition.x, leftLeg.transform.localPosition.y, leftLeg.transform.localPosition.z);
            rightLeg.SetActive(symEnabled);
        }
    }
        

    // Update is called once per frame
    void Update()
    {

        //kills the object if one of it's partners is destroyed
        if (leftLeg == null || rightLeg == null)
        {
            Destroy(gameObject);
        } else
        {
            //symmetry hot key
            if (Drag.selectedObj == rightLeg || Drag.selectedObj == leftLeg)
            {
                if (Input.GetKeyDown(KeyCode.S))
                {
                    ToggleSymmetry(!symEnabled);
                }
            }



            //moves the symmetry point to the torso if it exists
            if (torso != null)
            {
                if (!torso.gameObject.GetComponent<Drag>().isHeld && !leftLeg.GetComponent<Drag>().isHeld && !rightLeg.GetComponent<Drag>().isHeld)
                {

                    Vector3 leftTempPos = leftLeg.transform.position;
                    Vector3 rightTempPos = rightLeg.transform.position;
                    transform.position = torso.position;
                    leftLeg.transform.position = leftTempPos;
                    rightLeg.transform.position = rightTempPos;
                }
            }

            //mirrors all effects applied to one of the halves
            if (symEnabled)
            {
                //mirror left to right
                if (leftLeg.GetComponent<Drag>().isHeld)
                {
                    //position mirror
                    rightLeg.transform.localPosition = new Vector3(-leftLeg.transform.localPosition.x, leftLeg.transform.localPosition.y, leftLeg.transform.localPosition.z);
                }
                ///Mirror right to left
                if (rightLeg.GetComponent<Drag>().isHeld)
                {
                    //position mirror
                    leftLeg.transform.localPosition = new Vector3(-rightLeg.transform.localPosition.x, rightLeg.transform.localPosition.y, rightLeg.transform.localPosition.z);
                }
            }

            //these mirrors apply when symmetry is off so that it maintains symmtery when it turns on
            if (Drag.selectedObj == leftLeg)
            {
                //rotation mirror
                if (leftLeg.GetComponent<Drag>().isRotating != 0)
                {
                    rightLeg.GetComponent<Drag>().RotatePart(-leftLeg.GetComponent<Drag>().isRotating);
                }
                //scale or flip mirror
                rightLeg.transform.localScale = leftLeg.transform.localScale;
            }
            if (Drag.selectedObj == rightLeg)
            {
                //rotation mirror
                if (rightLeg.GetComponent<Drag>().isRotating != 0)
                {
                    leftLeg.GetComponent<Drag>().RotatePart(-rightLeg.GetComponent<Drag>().isRotating);
                }
                //flip mirror
                leftLeg.transform.localScale = rightLeg.transform.localScale;
            }

        }
    }
}
