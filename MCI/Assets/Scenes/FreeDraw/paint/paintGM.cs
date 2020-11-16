using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class paintGM : MonoBehaviour
{ 
    public Transform baseDot;
    public KeyCode mouseLeft;
  
    public static string toolType;
    public static bool cavDraw = false;
    public static Color currentColor;
    public static Color imageColor;
    public Vector2 prevVec = new Vector2(999,999);
    public static int currentScale = 4;
    private Texture2D texture ;
    public GameObject thing;

    void Start()
    {
        texture = new Texture2D(500, 250);
        imageColor = texture.GetPixel(500, 250);
    }

    void doTheArt()
    {
      
        if (toolType == "pencil" ||toolType=="eraser" )
        {
            
            if (Input.GetKey(mouseLeft)&& cavDraw)
            {
                int x = (int)Input.mousePosition.x;
                int y = (int)Input.mousePosition.y;
                /*                Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                                int x =(int) worldPoint.x;
                                 int y = (int)worldPoint.y;*/
                for (int i =0; i<currentScale; i++)
                {
                    for (int j = 0; j < currentScale; j++)
                    {
                        texture.SetPixel(x-25+i,y-105+j,currentColor);
                    }
                }
               if (prevVec.x != 999)
                {

                    for (int i = 0; i < currentScale; i++)
                    {
                        for (int j = 0; j < currentScale; j++)
                        {
                            //texture.SetPixel(x - 28 + i, y - 108 + j, currentColor);
                            DrawLine(new Vector2(prevVec.x, prevVec.y), new Vector2(x-25+i, y-105+j), currentColor);
                        }
                    }
                    
                }
                prevVec = new Vector2(x-25, y-105);


               texture.Apply();
               thing.GetComponent<Image>().sprite = Sprite.Create(texture, new Rect(0,0, 500,250), new Vector2 (0.5f,0.5f));

            }
          

        }


    }


    // Update is called once per frame
    void Update()
    {
        doTheArt();

    }

    void DrawLine( Vector2 p1, Vector2 p2, Color col)
    {
        Vector2 t = p1;
        float frac = 1 / Mathf.Sqrt(Mathf.Pow(p2.x - p1.x, 2) + Mathf.Pow(p2.y - p1.y, 2));
        float ctr = 0;

        while ((int)t.x != (int)p2.x || (int)t.y != (int)p2.y)
        {
            t = Vector2.Lerp(p1, p2, ctr);
            ctr += frac;
            texture.SetPixel((int)t.x, (int)t.y, col);
        }
    }

}
