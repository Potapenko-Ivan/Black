using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Scr : MonoBehaviour {
    public bool Tr = false,MR=false,TD=false,OnGr=false;
    public float Sp = 6,T=0f,TimeD=2.013f;
    //  public GameObject PL;
    public CamNewPos CP;
    public ConGGScr CS;
    public GameObject GG;
    public Rigidbody2D Rb;
    public Animator An;
	void Start () {
        An = GetComponent<Animator>();
        Rb = GetComponent<Rigidbody2D>();
        CS = GameObject.FindWithTag("Player").GetComponent<ConGGScr>();
        CP = GameObject.FindWithTag("MainCamera").GetComponent<CamNewPos>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Tr = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Tr = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((T>0||Tr)&&collision.gameObject.tag == "Gr")
        {
            T = 0.5f;
            MR = !MR;
        }
        if(collision.gameObject.tag=="Bullet")
        {
            Instantiate(GG, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0f), Quaternion.identity, gameObject.transform.parent);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            TD = true;
        }
        

    }
    void Update () {
        if (CP.T==true)
        {
            T = -100;
            Tr = false;
        }
		if(T>0 && !TD)
        {
            if (!MR)
            {
                Rb.velocity = new Vector2(1 * Sp, Rb.velocity.y);
                
            }
            else
            {
                Rb.velocity = new Vector2(1 * -Sp, Rb.velocity.y);
                
            }
            T -= Time.deltaTime;
        }
        else if(Tr && !TD)
        {
            if(CS.gameObject.transform.position.x<gameObject.transform.position.x)
            {
                Rb.velocity = new Vector2(1 * -Sp, Rb.velocity.y);
                MR = false;  
            }
            else
            {
                Rb.velocity = new Vector2(1 * Sp, Rb.velocity.y);
                MR = true;
            }

        }
        else
        {
            Rb.velocity = new Vector2(0, Rb.velocity.y);
        }
        if(TD)
        { TimeD -= Time.deltaTime;
            An.Play("AnEn3D");
            if(TimeD<=0)
            {
                Instantiate(GG, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0f), Quaternion.identity, gameObject.transform.parent);
                Destroy(this.gameObject);
            }

        }
        else
        {
            An.Play("AnEn3R");
        }
        
	}
}
