using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrScr : MonoBehaviour {
    public BoxCollider2D BoxC;
    public int K = -1;
	void Start () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="DNO")
        {
            // BoxC.isTrigger = false;
            gameObject.layer = 0;
            K = 0;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DNO")
        {
            //BoxC.isTrigger = true;
            gameObject.layer = 4;
            K = 4;

        }
    }
    void Update () {
		
	}
}
