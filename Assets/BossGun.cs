using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGun : MonoBehaviour {
    public bool InTr = false;
    public int ColBall = 3;
    public float timeT = 0.2f, T1=0f, T2=0f,t3=10,inSCol=2;
    public GameObject BulletObg,bullet,sp2,b1,vr;
    public BombScr bs;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "Player")
        {
            InTr = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
       // if (collision.gameObject.tag == "Player")
       // {
          //  InTr =false;
       // }
    }
    
    void Start () {
		
	}
	
	
	void Update () {
		if( T1<=0&&T2<0)
        {
            t3--;
            T1 = 0.2f;
            Instantiate(bullet,new Vector3(BulletObg.transform.position.x, BulletObg.transform.position.y, bullet.transform.position.x),bullet.transform.rotation);
        }
        T1 -= Time.deltaTime;
        if(InTr && t3<=0)
        {if (Random.Range(1, ColBall) == 2)
            {
                ColBall++;
                ColBall++;
                ColBall++;

                Instantiate(vr, new Vector3(sp2.transform.position.x, sp2.transform.position.y, vr.transform.position.x), Quaternion.identity);
            }
        }
        if (t3<=0)
        {
            T2 =  timeT;
            t3 = 5;
        }
        T2-= Time.deltaTime;
        if(inSCol<=0)
        {
            Instantiate(b1, new Vector3(sp2.transform.position.x, sp2.transform.position.y, b1.transform.position.z),Quaternion.Euler(0,0,-90));
            inSCol = 5f;
            bs.InTr = true;
        }
        inSCol-= Time.deltaTime;
    }
}
