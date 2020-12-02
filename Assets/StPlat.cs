using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StPlat : MonoBehaviour {
    public ConGGScr CS;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            CS.TD = true;
           // print("Hui");
        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
