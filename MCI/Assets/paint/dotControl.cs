using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class dotControl : MonoBehaviour
{

    public static dotControl Instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        /*if (Instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }*/

        if (paintGM.toolType == "eraser")
        {
            Destroy(gameObject);
        }
    }
}
