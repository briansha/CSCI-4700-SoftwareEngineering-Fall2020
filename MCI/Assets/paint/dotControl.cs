using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class dotControl : MonoBehaviour
{

    void Start()
    {
        GetComponent<SpriteRenderer>().color=paintGM.currentColor;
        GetComponent<Transform>().localScale = new Vector2(paintGM.currentScale, paintGM.currentScale);
    }
    void OnMouseOver()
    {
        if (paintGM.toolType == "eraser")
                {
                    Destroy(gameObject);
                }
    }


        
    
}
