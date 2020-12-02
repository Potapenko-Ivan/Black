using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContScrL : MonoBehaviour
{
    public Collider2D Col;
    public ConGGScr ContS;
    public Vector3 ClT;
    public Vector3 ClT2;
    public bool T=false;
    public int k = -1;
    public float z = 1;

    void Start()
    {

    }


    void Update()
    {
        if ((Input.touches.Length > 0))
        {
          //  print(Input.touches.Length);
            T = false;
            for (int i = 0; i < Input.touchCount; i++)
            {
            //    print(Input.touches[i].phase);

                ClT = new Vector3(Camera.main.ScreenToWorldPoint(Input.touches[i].position).x, Camera.main.ScreenToWorldPoint(Input.touches[i].position).y, z);
                if (Col.bounds.Contains(ClT))
                {

                    if (((Input.touches[i].phase == TouchPhase.Began))/*&&Col.bounds.Contains((Input.GetTouch(i).position))*/)
                    {
                        ContS.Ml1();
                    }
                    else if ((Input.touches[i].phase == TouchPhase.Stationary))
                    {

                        ContS.Ml1();

                    }
                    else if ((Input.touches[i].phase == TouchPhase.Moved))
                    {
                        ContS.Ml1();
                    }
                    else if (((Input.touches[i].phase == TouchPhase.Ended)))
                    {
                       // ContS.Ml2();
                    }
                    T = true;
                }
            }
            if (!T)
            {
                ContS.Ml2();
            }

        }
        else
        {
            ContS.Ml2();
        }
    }
}
