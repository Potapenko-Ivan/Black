using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotSleeveScr : MonoBehaviour {
    public Rigidbody2D Rb;
    public float F = 2f,RandR=5,RR=0;
    public float z,X,Y,TimeD=6;
    public bool TrInMenu = false;
  //  public AudioSource AS;


    private void OnCollisionEnter2D(Collision2D collision)
    {
      //  AS.Play();
    }


    public GameObject GO;
    void Start()
    {
   //     AS = GetComponent<AudioSource>();
        TimeD += Random.Range(RR, RandR) / 10f+(TrInMenu ? -3f : 0f);
        X += Random.Range(-30,30 ) / 100f ;
        Y += Random.Range(-30, 30) / 100f;
        // GO = GameObject.FindWithTag("RelM");//..GetComponent<GameObject>();
        Rb = GetComponent<Rigidbody2D>();

     //   gameObject.transform.position = new Vector2(GO.transform.position.x, GO.transform.position.y);
        Rb.AddForce(new Vector2(X,Y) * (F)*(TrInMenu?10f:1f), ForceMode2D.Impulse);
    }



    void Update()
    {
        if(TimeD<0)
        {
            Destroy(gameObject);
        }
        TimeD -= Time.deltaTime;
    }
}
