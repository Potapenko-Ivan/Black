using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContScrR : MonoBehaviour {
    public Collider2D Col;
    public ConGGScr ContS;
    public Vector3 ClT;
    public Vector3 ClT2;
    public int k = -1;
    public float z = 1;
    public bool T = false;

    void Start()
    {
        
       
        
    }


    void Update()
    {
        if ((Input.touches.Length > 0))
        {
            T = false;
            for (int i = 0; i < Input.touchCount; i++)
            {
                ClT = new Vector3(Camera.main.ScreenToWorldPoint(Input.touches[i].position).x, Camera.main.ScreenToWorldPoint(Input.touches[i].position).y, z);
                if (Col.bounds.Contains(ClT))
                {

                    if (((Input.touches[i].phase == TouchPhase.Began))/*&&Col.bounds.Contains((Input.GetTouch(i).position))*/)
                    {
                        ContS.Mr1();
                    }
                    else if ((Input.touches[i].phase == TouchPhase.Stationary))
                    {

                        ContS.Mr1();

                    }
                    else if ((Input.touches[i].phase == TouchPhase.Moved))
                    {
                        ContS.Mr1();
                    }
                    else if (((Input.touches[i].phase == TouchPhase.Ended)))
                    {
                       // ContS.Mr2();
                    }
                    T = true;
                }
            }
            if (!T)
            {
                ContS.Mr2();
            }

        }
        else
        {
            ContS.Mr2();
        }
    }
}
