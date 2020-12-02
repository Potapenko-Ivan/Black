using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScr : MonoBehaviour {
    public ENDScr ES;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            ES.TrEnd = true;
            
        }
    } 

    void Start () {
		
	}
	
	void Update () {
		
	}
}
