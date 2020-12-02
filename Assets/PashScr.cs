using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PashScr : MonoBehaviour {
    public GameObject Obj,Obj2;
    //public static bool TrIn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Obj.SetActive(false);
            Obj2.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Obj.SetActive(true);
           // Obj2.SetActive(false);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
