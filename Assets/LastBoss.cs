using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastBoss : MonoBehaviour {
    public bool TrSt = true,TrLD=false,TrUp=false,TrLGun=true,TrRGun=true,TrInAir= false,BulletPhase = true,TrR=true,t3=true,t=true,t1=true,TrD=false;
    public float TimeSh = 0.2f, TimeSh1=0.2f,JF=10f,TimeAt=5f, TimeAt1=5f,Sp=6f,BuletTimeSh=0, BuletTimeSh1=0.7f;
    public Rigidbody2D rb;

    public GameObject[] pulPoz=new GameObject[8];
    public bool[] pulPozTr = new bool[8];
   
    public GameObject StrVP, StrVL,TP,TL,Bullet;
	void Start () {
		for(int i=0;i<8;i++)
        {
            pulPozTr[i] = true;
        }
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LWall")
        {
            print("2");
            TrInAir = true;
            rb.constraints = RigidbodyConstraints2D.None;

            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
          
            


            TimeAt = TimeAt1;
            t1 = true;
            //TrInAir = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gr")
        {
            TrSt = true;
        }
    }
    public void str()
    {
        if (BuletTimeSh<=0)
        {
            for (int i = 0; i < 8; i++)
            {
                if (pulPozTr[7-i])
                {
                    if (TrR)
                    {
                    Instantiate(Bullet, new Vector2(pulPoz[i].transform.position.x, pulPoz[i].transform.position.y), BulletPhase ? Quaternion.Euler(0f, 0f, 11f*i): Quaternion.Euler(0f, 0f, -11f*(8-i)));

                    }
                    else
                    {
                        Instantiate(Bullet, new Vector2(pulPoz[i].transform.position.x, pulPoz[i].transform.position.y), BulletPhase ? Quaternion.Euler(0f, 0f, -11f * i) : Quaternion.Euler(0f, 0f, 11f * (8 - i)));

                    }
                }
                
            }
            BulletPhase = !BulletPhase;
            BuletTimeSh = BuletTimeSh1; 
        }
        else
        {
            BuletTimeSh -= Time.deltaTime;
        }
        

    }
    void Update () {
        if (!TrD)
        {


            if (TimeSh <= 0 && TrSt)
            {
                if (TrR)
                {
                    if (TrLGun) Instantiate(StrVP, new Vector2(TP.gameObject.transform.position.x, TP.gameObject.transform.position.y), StrVP.transform.rotation);
                    if (TrRGun) Instantiate(StrVL, new Vector2(TL.gameObject.transform.position.x, TL.gameObject.transform.position.y), StrVL.transform.rotation);

                }
                else
                {
                    if (TrLGun) Instantiate(StrVL, new Vector2(TP.gameObject.transform.position.x, TP.gameObject.transform.position.y), StrVL.transform.rotation);
                    if (TrRGun) Instantiate(StrVP, new Vector2(TL.gameObject.transform.position.x, TL.gameObject.transform.position.y), StrVP.transform.rotation);

                }
                TimeSh = TimeSh1;
            }
            if (TrUp)
            {
                BuletTimeSh = 0.12f;
                rb.AddForce(new Vector2(0, JF), ForceMode2D.Impulse);
                TrSt = false;
                TrUp = false;
            }
            TimeSh -= Time.deltaTime;
            if(TimeAt<0.8)
            {
                BuletTimeSh=0.2f;
            }
            if (TrInAir && TimeAt > 0)
            {
                //  print(1);

                if (t1)
                {
                    gameObject.transform.rotation *= Quaternion.Euler(0f, 180f, 0f);
                    TrR = !TrR;
                    t1 = false;
                }
                TimeAt -= Time.deltaTime;
                if (Mathf.Abs(gameObject.transform.position.x - ConGGScr.XposG) <= 1)
                {
                    rb.velocity = new Vector2(0, 0);

                }
                else if (ConGGScr.XposG > gameObject.transform.position.x)
                {
                    rb.velocity = new Vector2(Sp, 0);
                }
                else
                {
                    rb.velocity = new Vector2(-Sp, 0);

                }
            }
            if (TimeAt <= 0)
            {
                rb.constraints = RigidbodyConstraints2D.None;
                rb.constraints = RigidbodyConstraints2D.FreezeRotation;
                TrInAir = false;
            }
            if (!TrSt)
            {

                str();
            }
            if(!TrLGun&&!TrRGun&&t)
            {
                t = false;
                Sp *= 1.5f;
                BuletTimeSh1 *=0.8f;
            }
            if ((!TrLGun || !TrRGun) && t3)
            {
                t3 = false;
                Sp *= 1.4f;
                BuletTimeSh1 *= 0.98f;

                TimeSh1 *= 0.75f;
            }
        }
    }
}
