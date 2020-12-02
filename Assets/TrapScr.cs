using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine;
public class TrapScr : MonoBehaviour {
    public Animator An;
    public bool nast = false;
    public float i=1f,i2=0f;
    void Start () {
        An.speed = i;
        // Ass = GetComponent<AnimationState>();
        //  Ass = An.GetComponent<Animation>();

    }
	

	void Update () {
        if ((i2<=0))
        {
            An.speed = i;
            
        }
        else
        {
            An.speed = 0;
            i2 -= Time.deltaTime;
        }

    }
}
