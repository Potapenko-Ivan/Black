using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScr : MonoBehaviour
{
    /*  public Collider2D Col;
       public ConGGScr ContS;
       public Vector3 ClT;
       public float z = 0;*/
    public Toggle Tg;
    public bool Tl = false;
    public Collider2D Col;
    public ConGGScr ContS;
    public Vector3 ClT;
    /// public Vector3 ClT2;

    public float z = 1;
    public GameObject Obj;
    //public GameObject ObjCan;

    void Start()
    {
        Time.timeScale = 1;
        OnPauseScr.TrVol = PlayerPrefs.GetInt("Vol") == 1 ? true : false;
        print(OnPauseScr.TrVol);
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
        
        if ((Input.touches.Length > 0))
        {
            for (int i = 0; i < Input.touchCount; i++)
            {


                if (((Input.touches[i].phase == TouchPhase.Began)))
                {

                    ClT = new Vector3(Camera.main.ScreenToWorldPoint(Input.touches[i].position).x, Camera.main.ScreenToWorldPoint(Input.touches[i].position).y, z);
                    if (Col.bounds.Contains(ClT))
                    {
                        if (!ContS.TrPause)
                        {

                            ContS.TrPause = true;
                            Time.timeScale = 0;
                            Tg.isOn = OnPauseScr.TrVol;
                            // Instantiate(Obj,ObjCan.transform);
                            Tl = true;
                            Obj.SetActive(true);
                            







                        }

                        ///  ClT2 = new Vector3(Camera.main.ScreenToWorldPoint(Input.touches[i].position).x, Camera.main.ScreenToWorldPoint(Input.touches[i].position).y, z);
                    }


                }
            }

        }
    }
}
