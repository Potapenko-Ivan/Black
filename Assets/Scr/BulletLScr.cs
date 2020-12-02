using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLScr : MonoBehaviour {

    public Rigidbody2D Rb;
    public bool Tr;

    public float Sp = 2;
    // Use this for initialization
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();


       // gameObject.transform.position = new Vector2(0, 0);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="LWall"|| collision.gameObject.tag == "Gr")
        {
            Destroy(gameObject);

        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {




        Rb.velocity = new Vector2(1 * Sp, Rb.velocity.y);

    }
}
