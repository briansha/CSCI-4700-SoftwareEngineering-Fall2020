using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (gameObject.name == "eraser")
        {
            paintGM.toolType = "eraser";
            //Debug.Log("eraser selected");
        }
        if (gameObject.name == "pencil")
        {
            paintGM.toolType = "pencil";
            //Debug.Log("pencil selected");
        }
    }
}
