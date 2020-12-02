using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBokScr : MonoBehaviour {
    public GameObject Go,Go2;
    public LastBoss LB;
    public Rigidbody2D Rb;
    public bool Ebalo = false, LG = false, RG = false, Strelki = false,Bok=false;
    public int Por;
	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Bullet")
        {
            Destroy(collision.gameObject);
            if (LG)
            {
                LB.TrLGun = false;
            }
            if (Bok)
            {
                LB.Sp*=1.2f;
                LB.TimeAt1 *= 1.4f;
            }
            if (RG)
            {
                LB.TrRGun = false;
            }
            if (Ebalo)
            {
                Rb.constraints = RigidbodyConstraints2D.None;
                Rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                LB.TrD = true;
                Rb.constraints = RigidbodyConstraints2D.FreezePositionX;
                Go2.SetActive(true);
            }
            if (Strelki)
            {
                LB.pulPozTr[Por] = false;
                LB.Sp *= 1.1f;

            }
            LB.TrUp = true;
            Instantiate(Go,new Vector2(gameObject.transform.position.x, gameObject.transform.position.y),Go.transform.rotation);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
