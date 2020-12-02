using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContScrJ : MonoBehaviour {
  /*  public Collider2D Col;
    public ConGGScr ContS;
    public Vector3 ClT;
    public float z = 0;*/
    public Collider2D Col;
    public ConGGScr ContS;
    public Vector3 ClT;
    public Vector3 ClT2;
    public int k = -1;
    public float z = 1;
    void Start()
    {

    }


    void Update()
    {
      //  print(Input.touches.Length);
        
        if ((Input.touches.Length > 0))
        {
            for (int i = 0; i < Input.touchCount; i++)
            {


                if (((Input.touches[i].phase == TouchPhase.Began))/*&&Col.bounds.Contains((Input.GetTouch(i).position))*/)
                {
                    ClT = new Vector3(Camera.main.ScreenToWorldPoint(Input.touches[i].position).x, Camera.main.ScreenToWorldPoint(Input.touches[i].position).y, z);
                    if (Col.bounds.Contains(ClT))//Col.bounds.Contains(ClT))
                    {
                        ContS.Jump();
                        k = i;
                    }

                    ClT2 = new Vector3(Camera.main.ScreenToWorldPoint(Input.touches[i].position).x, Camera.main.ScreenToWorldPoint(Input.touches[i].position).y, z);
                }

                //print(Input.touches[i].p);
            }
        }
        

    




    /*
    if ((Input.touches.Length > 0))
    {
        for (int i = 0; i < (Input.touchCount < 3 ? Input.touchCount : 2); i++)
        {

            if (((Input.touches[i].phase == TouchPhase.Began) || (Input.touches[i].phase == TouchPhase.Moved))/*&&Col.bounds.Contains((Input.GetTouch(i).position))))
            {
                ClT = new Vector3(Camera.main.ScreenToWorldPoint(Input.touches[i].position).x, Camera.main.ScreenToWorldPoint(Input.touches[i].position).y, z);
                if (Col.bounds.Contains(ClT))//Col.bounds.Contains(ClT))
                {
                    ContS.Jump();
                }

            }
        }
    }*/
}
}
