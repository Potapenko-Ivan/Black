using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleeveScr : MonoBehaviour {
    public Rigidbody2D Rb;
    public float F=2f;
    public float z, TimeD = 6;
    public ConGGScr CS;
 //   public AudioSource AS;
    public GameObject GO;
    void Start()
    {
        TimeD += Random.Range(-10, 10) / 10f;
        GO = GameObject.FindWithTag("RelM");//..GetComponent<GameObject>();
        CS = GameObject.FindWithTag("Player").GetComponent<ConGGScr>();
      //  AS = GetComponent<AudioSource>();
        gameObject.transform.position = new Vector2(GO.transform.position.x, GO.transform.position.y);
        Rb.AddForce(new Vector2(CS.TrR?-1:1,1)*(F+Random.Range(-15,15)/10f),ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      // AS.Play();
    }

    void Update()
    {
        if (TimeD < 0)
        {
            Destroy(gameObject);
        }
        TimeD -= Time.deltaTime;
    }
}
