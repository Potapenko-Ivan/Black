using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatPad : MonoBehaviour {
    //public Rigidbody2D Rb;
    public float T = 3f;
    public bool OnT = false;
  //  public Animator An;
    public GameObject GO;
	void Start () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            OnT = true;
        }
    }
    
    // Update is called once per frame
    void Update () {
		if(OnT)
        {
         //   An.Play("AnTr2");
            T -= Time.deltaTime;
        }
        if(T<=0)
        {
            Instantiate(GO, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y), Quaternion.identity);

          //  An.Play("AnTr2");
            OnT = false;
           
            Destroy(gameObject);
        }
	}
}
