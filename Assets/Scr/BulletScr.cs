using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScr : MonoBehaviour {
    public Rigidbody2D Rb;
    public GameObject GO;
    public bool Tr;
    public ConGGScr CS;
    public float Sp=2,TimeD=0.4f;
    // Use this for initialization
    void Start () {
        Rb = GetComponent<Rigidbody2D>();
        GO = GameObject.FindWithTag("Relm2");//..GetComponent<GameObject>();
        CS = GameObject.FindWithTag("Player").GetComponent<ConGGScr>();
        gameObject.transform.position = new Vector2(GO.transform.position.x, GO.transform.position.y);
        Tr = CS.TrR;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
        if(TimeD<=0)
        {
            Destroy(gameObject);

        }
        else
        {
            TimeD-=Time.deltaTime;
        }
		if(Tr)
        {
            Rb.velocity = new Vector2(1 * Sp, Rb.velocity.y);

        }
        else
        {
            Rb.velocity = new Vector2(-1 * Sp, Rb.velocity.y);

        }
    }
}
