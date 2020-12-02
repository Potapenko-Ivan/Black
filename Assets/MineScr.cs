using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScr : MonoBehaviour {
    public bool OnEx = false,OnJ=false,OnGr=true;
    public float F = 1,y;
    public Rigidbody2D rb;
    public GameObject Obj;

   
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !OnEx)
        {
            OnEx = true;
            y = collision.gameObject.transform.position.y;
        }
    }
    void Start () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (OnJ&&!OnGr)
        {
             Instantiate(Obj,new Vector2(gameObject.transform.position.x, gameObject.transform.position.y),Quaternion.identity);
            Destroy(gameObject);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gr")
        {
            OnGr = false;
        }
    }
    void Update () {
		if(OnEx&&!OnJ)
        {
            rb.AddForce(new Vector2(0, 1 * F), ForceMode2D.Impulse);
            OnJ = true;
        }
        if(OnEx&&gameObject.transform.position.y>=y)
        {
            Instantiate(Obj,new Vector2(gameObject.transform.position.x, gameObject.transform.position.y),Quaternion.identity);
            Destroy(gameObject);
        }
	}
}
