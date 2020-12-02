using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrScr : MonoBehaviour {

    public bool TrIn = false;
	void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Gr" || (collision.gameObject.tag == "GrM"))
        {
            TrIn = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gr" || (collision.gameObject.tag == "GrM"))
        {
            TrIn = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gr" || (collision.gameObject.tag == "GrM"))
        {
            TrIn =true;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
