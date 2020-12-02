using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGr1Scr : MonoBehaviour {
    public bool TrJ=false,TrD=false,Tdef=false,TrInA=false, TrdestroiBlock = false, TrInA1=false;
    public float TimeDest = 0.1f, TimeDest1 = 0.1f, TJ = 2f, TJ1 = 2f, Jforse = 20f,mooveF = 10f,TMove, mooveFX;
    public GameObject Go,Go1,Go2;
    public Rigidbody2D Rb;
	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Gr"&&TrInA1)
        {
            TJ = TJ1;
            TrInA1 = false;
            TrdestroiBlock = true;
            Rb.velocity = new Vector2(0f,0f);
        }
        if(!TrInA1)
        {
            Rb.velocity = new Vector2(Rb.velocity.x, Rb.velocity.y * 0.001f);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gr" && TrdestroiBlock&&TimeDest >= 0)
        {
          //  Instantiate(Go2, new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y), Quaternion.identity);
          //  Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag=="LWall")
        {
           
            TrInA = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Gr" && TrdestroiBlock && TimeDest >= 0)
        {
            Instantiate(Go2, new Vector2(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y), Quaternion.identity);
            Destroy(collision.gameObject);
              
        }
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        /*TrJ = false;
        TrD = false;
        Tdef = false;
        TrInA = false;
        TrdestroiBlock = false;
        TrInA1 = false;*/
    }
    // Update is called once per frame
    void Update () {
		if(TrD)
        {
            Go.SetActive(true);
        }
        else
        {
            if(TrJ)
            {
                Rb.velocity = new Vector2(0f, 0f);
                Rb.AddForce(new Vector2(0f, Jforse), ForceMode2D.Impulse);
                
                TrJ = false;
            }
          
            if(TrInA)
            {
                
                gameObject.transform.position = new Vector2(ConGGScr.XposG, gameObject.transform.position.y);
                Rb.AddForce(new Vector2(0f, -Jforse*0.1f), ForceMode2D.Impulse);
                TrInA1 = true;
                TrInA = false;
            }
            if(TrdestroiBlock)
            {
                TimeDest -= Time.deltaTime;
            }
            else
            {
                TimeDest = TimeDest1;
            }
        }
	}
}
