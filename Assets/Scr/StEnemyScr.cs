using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StEnemyScr : MonoBehaviour {
    public bool RW = false, LW = false, Up = false, Down = false,TR=false;
    public Rigidbody2D Rb;
    public float Sp = 2;
    public GameObject GGR,GGL,GGU,GGD,Exp;
   
    void Start () {
        Rb = GetComponent<Rigidbody2D>();
       
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if ((TR) || (collision.gameObject.tag == "Bullet"))
        {
            Instantiate(Exp, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0f), Quaternion.identity, gameObject.transform.parent);
            if (Up )
            {
                Instantiate(GGU, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0f), Quaternion.identity/*Quaternion.Euler(0, 0, 90)*/, gameObject.transform.parent);

                Destroy(gameObject);

            }
            if (Down)
            {
                Instantiate(GGD, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0f), Quaternion.identity/*Quaternion.Euler(0, 0, -90)*/, gameObject.transform.parent);
                Destroy(gameObject);


            }
            if (RW)
            {
                Instantiate(GGR, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0f), Quaternion.identity/*Quaternion.identity*/, gameObject.transform.parent);
                Destroy(gameObject);

            }
            if (LW)
            {
                Instantiate(GGL, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0f), Quaternion.identity/*.Euler(0, 180,0)*/, gameObject.transform.parent);

                Destroy(gameObject);

            }

        }
    }
 
    void Update () {
		if(TR)
        {

            if(Up)
            {
                Rb.velocity = new Vector2(0, 1*-Sp);


            }
            if (Down)
            {
                Rb.velocity = new Vector2(0, 1 * Sp);

            }
            if (RW)
            {
                Rb.velocity = new Vector2(1  * -Sp, 0);

            }
            if (LW)
            {
                Rb.velocity = new Vector2(1 * Sp, 0);

            }

        }
	}
}
