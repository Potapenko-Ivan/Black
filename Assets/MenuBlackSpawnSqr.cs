using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBlackSpawnSqr : MonoBehaviour {
    /*  public Collider2D Col;
      public ConGGScr ContS;
      public Vector3 ClT;
      public float z = 0;*/
    public bool Wait = false;
    public float Ti = 0f;
    public bool Tl = false;
    public Collider2D Col;
   // public ConGGScr ContS;
    public Vector3 ClT;
    /// public Vector3 ClT2;
    public GameObject Obj;
    //public GameObject ObjCan;

    void Start()
    {
      
        //OnPauseScr.TrVol = !OnPauseScr.TrVol;
        /*   if (!OnPauseScr.TrVol)
           {
               AudioListener.volume = 0f;
           }
           else
           {
               AudioListener.volume = 1f;
           }*/
    }


    void Update()
    {
        if(Ti>=10)
        {
            Wait = true;
            Ti /= 4f;
        }
        if (Ti <= 0)
        {
            Wait = false;
        }
        else
        {
            Ti -= (Time.deltaTime);

        }
        
        if ((Input.touches.Length > 0))
        {
            for (int i = 0; i < Input.touchCount; i++)
            {


                if (((Input.touches[i].phase == TouchPhase.Began)))
                {
                   // print("Hui");

                    ClT = new Vector3(Camera.main.ScreenToWorldPoint(Input.touches[i].position).x, Camera.main.ScreenToWorldPoint(Input.touches[i].position).y,0f);
                    if (Col.bounds.Contains(ClT))
                    {
                       // print("Hui");
                        Instantiate(Obj, new Vector2(Camera.main.ScreenToWorldPoint(Input.touches[i].position).x, Camera.main.ScreenToWorldPoint(Input.touches[i].position).y), Quaternion.identity);
                        Ti += 1.5f;
                        ///  ClT2 = new Vector3(Camera.main.ScreenToWorldPoint(Input.touches[i].position).x, Camera.main.ScreenToWorldPoint(Input.touches[i].position).y, z);
                    }


                }
            }

        }
    }
}
