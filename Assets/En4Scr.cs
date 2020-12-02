using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class En4Scr : MonoBehaviour {
    public bool ML = false, MR = false, J = false, B = false, TrR = true, TrSh = false, TD = false, TLW = false, TrJB = false;
    public float Sp = 0.1f, Jf = 0.1f, ShT = 0f, ST = 0.458f;
    public GameObject Bul, Sleeve;
    public Rigidbody2D rb;
    public GameObject Vz;
    public Animator An;
    public AudioSource As1, As2, As3;
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gr")
        {
            J = false;
            //As2.Play();
        }
        if (collision.gameObject.tag == "Stake")
        {
            TD = true;

        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gr")
        {
            J = true;


        }


    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gr")
        {
            J = false;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LWall")
        {


        }
        if (collision.gameObject.tag == "Stake")
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


        rb.velocity = new Vector2(-1 * Sp, rb.velocity.y);
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

        rb.velocity = new Vector2(1 * Sp, rb.velocity.y);

    }
    public void Jump()
    {
        if (!J)
        {

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

        if (ML)
        {

            MooveL();




        }
        else if (MR)
        {
            MooveR();


        }
        else
        {
            if (!J)
            {
                rb.velocity = new Vector2(0f, rb.velocity.y);

            }
            else
            {
                rb.velocity = new Vector2(0f, rb.velocity.y);

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
            transform.rotation = new Quaternion(0f, 0f, 0f, 0f);

        }
        else
        {
            transform.rotation = new Quaternion(0f, 180f, 0f, 0f);

        }

        if (ShT > 0)
        {
            ShT -= Time.deltaTime;
            An.Play("AnGunSh");


        }
        else
        {
            if (TrSh)
            {
              /*  Instantiate(Bul);
                Instantiate(Sleeve);
                */
                ShT = ST;
                As3.Play();
            }
            An.Play("AnGunR");

        }

        if (TD)
        {
            Time.timeScale = 0.4f;
            Instantiate(Vz);
            Destroy(gameObject);
        }
        if (TLW)
        {
            if (rb.velocity.x < 0)
            {
                rb.velocity = new Vector2(0, rb.velocity.y);

            }
        }
        TrJB = J;
    }
}
