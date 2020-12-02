using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScr : MonoBehaviour {
    public float JY = 4,jX=1,Jx2,YRaz=1;
    public Rigidbody2D Rb;
   // public GameObject Cam;
    public GameObject Go;
    public bool OnGr = false;

    //public PhysicsMaterial2D M1, M2;
    public bool TrJ = true;
	void Start () {
		
	}
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        // print((gameObject.transform.position.y - ConGGScr.YposG));

        if ((collision.gameObject.tag == "Player") && (Mathf.Abs(gameObject.transform.position.y - ConGGScr.YposG) <= YRaz))
        {


            TrJ = false;
            Rb.velocity = new Vector2(0f, 0f);

            Rb.AddForce(new Vector2(ConGGScr.XposG < gameObject.transform.position.x ? 1 * Jx2 : -1 * Jx2, 0f), ForceMode2D.Impulse);

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        if ((collision.gameObject.tag == "Player") && (Mathf.Abs(gameObject.transform.position.y - ConGGScr.YposG) <= YRaz))
        {


            TrJ = false;
            Rb.velocity = new Vector2(0f, 0f);

            Rb.AddForce(new Vector2(ConGGScr.XposG < gameObject.transform.position.x ? 1 * Jx2 : -1 * Jx2, 0f), ForceMode2D.Impulse);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
           // print("xyi");
            Instantiate(Go,new Vector2(gameObject.transform.position.x, gameObject.transform.position.y),Quaternion.identity,gameObject.transform.parent);
            Destroy(gameObject);

        }
        if (collision.gameObject.tag == "Gr")
        {
            OnGr = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TrJ = true;
            Rb.velocity = new Vector2(Rb.velocity.x/10f, Rb.velocity.y/10f);


        }
    }
    // Update is called once per frame
    void Update () {
		if(TrJ && OnGr)
        {
            Rb.AddForce(new Vector2(ConGGScr.XposG < gameObject.transform.position.x? 1* jX:-1 * jX, 1 * JY), ForceMode2D.Impulse);
            TrJ = false;
        }
	}
}
