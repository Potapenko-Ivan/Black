using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ConGGScr : MonoBehaviour {
    public static float XposG = 1,YposG=1; 
    public bool ML = false, MR = false, J = false, B = false, TrR = true,TrSh=false,TD=false,TLW=false,TrJB=false,TrB=false,TrPause=false,TrBoss1=false;
    public float Sp = 0.1f, Jf = 0.1f,ShT=0f,ST= 0.458f,tzSh=0f,col=0f,cr=1,Tew=0.2f,TB=0f,tc= 0.08f;
    public GameObject Bul,Sleeve,sled;
    public Rigidbody2D rb;
    public GameObject Vz;
    public Animator An;
    public AudioSource As1, As2, As3;
    public CamNewPos Cp;
    public TrScr TR;
    public int Ids;
        void Start()
    {
      
        rb = GetComponent<Rigidbody2D>();
      //  Application.targetFrameRate = 400;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Gr") || (collision.gameObject.tag == "GrM"))
        {
            if (TR.TrIn)
            {
                TrB = false;
                TB = 0;
                J = false;
            }
            //As2.Play();
        }
        if (collision.gameObject.tag == "Stake")
        {
            TD = true;

        }
        if (collision.gameObject.tag == "Ball")
        {
            TD = true;

        }


    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gr" || collision.gameObject.tag == "GrM")
        {
            //  J = true;
            if (!J)
            {
                TB = tc;
                TrB = true;
            }

        }
       

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gr"|| collision.gameObject.tag == "GrM")
        {
            if (TR.TrIn) {
                J = false;
                TrB = false;
                TB = 0;
            }

        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LWall")
        {
           

        }
        if (collision.gameObject.tag == "Stake")
        {
           // TD = true;

        }
        if (collision.gameObject.tag == "Ballet2")
        {
            TD = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LWall")
        {
           

        }
    }
    public void Ml1()
    {
        ML = true;
        TrR = false;
    }

    public void Ml2()
    {
        ML = false;
    }
    public void Mr1()
    {
        MR = true;
        TrR = true;

    }

    public void Mr2()
    {
        MR = false;
    }
    public void MooveL()
    {

       if(!TD)
        {
            rb.velocity = new Vector2(-1 * Sp, rb.velocity.y);

        }
    }
    public void Shoot()
    {
        TrSh = true;
       /* if(ShT<=0)
        {
            Instantiate(Bul);
            Instantiate(Sleeve);

            ShT = ST;

        }*/

    }
    public void Shoot1()
    {
        TrSh = false;

        /* if(ShT<=0)
         {
             Instantiate(Bul);
             Instantiate(Sleeve);

             ShT = ST;

         }*/

    }
    public void MooveR()
    {
        if(!TD)
        {
            rb.velocity = new Vector2(1 * Sp, rb.velocity.y);

        }

    }
    public void Jump()
    {
        
      
        if (!J&&!TD&&!TrBoss1)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);

            rb.AddForce(new Vector2(0, 1 * Jf), ForceMode2D.Impulse);
            J = true;
            As1.Play();
        }
    }
    public void Kl_4()
    {

    }
    void Update()
    {
        if (!TrPause)
        {

            XposG = gameObject.transform.position.x;
            YposG = gameObject.transform.position.y;

            if (ML)
            {

                MooveL();

                transform.rotation = new Quaternion(0f, 180f, 0f, 0f);


            }
            else if (MR)
            {
                MooveR();
                transform.rotation = new Quaternion(0f, 0f, 0f, 0f);

            }
            else
            {
                if (!J && !TrBoss1)
                {
                    rb.velocity = new Vector2(0f, rb.velocity.y);
                }
                else
                {

                    if ((rb.velocity.y) > -10f)
                    {if( !TrBoss1)
                        rb.velocity = new Vector2(0f, rb.velocity.y);
                    }
                    else
                    {
                        if (!TrBoss1) rb.velocity = new Vector2(0f, -10f);
                    }
                }


            }
            if (!J)
            {
                if (TrJB)
                {

                }
            }

            if (TrR)
            {


            }
            else
            {


            }

            if (ShT > 0)
            {
                ShT -= Time.deltaTime;
                An.Play("AnGunSh");


            }
            else
            {
                tzSh -= Time.deltaTime;
                if (TrSh && (tzSh < 0))
                {
                    Instantiate(Bul);
                    Instantiate(Sleeve);

                    ShT = ST;
                    As3.Play();
                    tzSh = 0.1f;
                }
                An.Play("AnGunR");

            }

            if (TD)
            {
                Tew -= Time.deltaTime;
                Time.timeScale = 0.4f;
                //   Instantiate(Vz);
                //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                ///   Destroy(gameObject);
                ///   
                Cp.T = true;
                Destroy(gameObject);
                Instantiate(Vz);

            }

            if (Tew <= 0)
            {

            }
            if (TLW)
            {
                if (rb.velocity.x < 0)
                {
                    if (!TrBoss1) rb.velocity = new Vector2(0, rb.velocity.y);

                }
            }
            TrJB = J;

            Ids = PlayerPrefs.GetInt("IntCol");
            //  print(Ids);
            TB -= Time.deltaTime;
            if (TrB && (MR || ML) && TB <= 0f)
            {
                J = true;
                TrB = false;

            }
            else if (TrB && (!MR && !ML))
            {
                J = true;
                TrB = false;
            }
        }
    }
}
