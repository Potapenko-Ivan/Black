using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatScr : MonoBehaviour {
    public Rigidbody2D Rb;
    public float Sp = 9f, TimeN = 0f;
	//public bool TrUp = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="PlDrop")
        {
          
            TimeN = 2f;
        }
    }
    void Start () {
		
	}
	
	
	void Update () {
		if(TimeN<=0)
        {
            Rb.velocity = new Vector2(0f,Sp);
        }
        else
        {
           // Rb.velocity = new Vector2(0f, 0f);
            TimeN -= Time.deltaTime;
        }
    }
}
