using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MooveWallScr : MonoBehaviour {
    public float Sp = 11f,Tm=0.5f;
    public bool Right = true;
    public Rigidbody2D Rb;
	void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Stop")
        {
            Sp = 0;
        }
    }

    void Update () {
        if(Tm<=0)
        {
            Rb.velocity = new Vector2((Right ? Sp : -Sp), 0f);

        }
        else
        {
            Tm -= Time.deltaTime;
        }
    }
}
