using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.mousePosition.y < 205)
        {
            transform.position = Input.mousePosition + (Vector3.up * 205);
        }
        else
        {
            transform.position = Input.mousePosition;
        }
    }
}
