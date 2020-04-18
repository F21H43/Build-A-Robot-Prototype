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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (leftLeg == null || rightLeg == null)
        {
            Destroy(gameObject);
        }
        if(torso != null)
        {
            transform.position = torso.position;
        }

        if (leftLeg.GetComponent<Drag>().isHeld)
        {
            rightLeg.transform.localPosition = new Vector3(-leftLeg.transform.localPosition.x, leftLeg.transform.localPosition.y, leftLeg.transform.localPosition.z);
        }

        if (rightLeg.GetComponent<Drag>().isHeld)
        {
            leftLeg.transform.localPosition = new Vector3(-rightLeg.transform.localPosition.x, rightLeg.transform.localPosition.y, rightLeg.transform.localPosition.z);
        }

        
    }
}
