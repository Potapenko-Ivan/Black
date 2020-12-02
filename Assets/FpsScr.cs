using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FpsScr : MonoBehaviour {

    //public float updateInterval = 0.5F;
   // private double lastInterval;
  //  private int frames = 0;
    private float fps;
    public Text T;
    void Start()
    {
       // lastInterval = Time.realtimeSinceStartup;
        //frames = 0;
    }

    

    void Update()
    {
        /* ++frames;
         float timeNow = Time.realtimeSinceStartup;
         if (timeNow > lastInterval + updateInterval)
         {*/
        //  fps = (float)(frames / (timeNow - lastInterval));
        fps = 1.0f / Time.deltaTime;

        /*     frames = 0;
             lastInterval = timeNow;
         }*/
        T.text = ((int)fps).ToString();
    }
}
