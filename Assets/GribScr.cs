using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GribScr : MonoBehaviour {
    public bool TrM = false, Mr;

    public float Sp = 4f;

    public Rigidbody2D Rb;

    public GameObject Go;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            TrM = true;
            if (collision.gameObject.transform.position.x > gameObject.transform.position.x)
            {
                Mr = true;
            }
            else
            {
                Mr = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Bullet")
        {
            Instantiate(Go,new Vector2(gameObject.transform.position.x, gameObject.transform.position.y),Quaternion.identity);
            Destroy(gameObject);
        }
    }
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (TrM)
        {
            Rb.velocity = new Vector2(Mr?Sp:-Sp, Rb.velocity.y);
        }
    }
}
