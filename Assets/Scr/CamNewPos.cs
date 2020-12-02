using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CamNewPos : MonoBehaviour
{
    public float XPos, YPos;
    public ConGGScr CG;
    public bool T = false;
    public Rigidbody2D Rb;
    public float Sp = 0.1f, um = 0.1f, SpX = 0.1f, umX = 0.1f, Times=0f,Vel;
    void Start()
    {
        XPos = CG.gameObject.transform.position.x - gameObject.transform.position.x;
        YPos = CG.gameObject.transform.position.y - gameObject.transform.position.y;


    }

    public void CamMooveY()
    {
       // gameObject.transform.position = new Vector3(CG.gameObject.transform.position.x - XPos, CG.gameObject.transform.position.y - YPos, gameObject.transform.position.z);
        // gameObject.transform.position = new Vector3(CG.gameObject.transform.position.x - XPos, gameObject.transform.position.y, gameObject.transform.position.z);



        if (CG.gameObject.transform.position.y - YPos - gameObject.transform.position.y > 0.2f)
        {
            if (Rb.velocity.y < 12)
            {
                if (CG.gameObject.transform.position.y - YPos - gameObject.transform.position.y < 3f && (Rb.velocity.y > 2))
                {


                    Rb.velocity = new Vector2(Rb.velocity.x, 1.1f * Rb.velocity.y * um );


                }
                else
                {
                    Rb.velocity = new Vector2(Rb.velocity.x, Rb.velocity.y + Sp );

                }
            }
        }
        else if (CG.gameObject.transform.position.y - YPos - gameObject.transform.position.y < -0.2f)
        {
            if (Rb.velocity.y > -17)
            {
                if (CG.gameObject.transform.position.y - YPos - gameObject.transform.position.y > -3f && (Rb.velocity.y < -2))
                {

                    Rb.velocity = new Vector2(Rb.velocity.x, 1.1f * Rb.velocity.y * um );


                }
                else
                {
                    if(CG.gameObject.transform.position.y - YPos - gameObject.transform.position.y < -3f)
                    {
                        if(CG.gameObject.transform.position.y - YPos - gameObject.transform.position.y < -4f)
                        {
                            Rb.velocity = new Vector2(Rb.velocity.x, -14.5f);
                        }
                        else
                        {
                            Rb.velocity = new Vector2(Rb.velocity.x, Rb.velocity.y - Sp * 2.2f);

                        }

                    }
                    else
                    {
                        Rb.velocity = new Vector2(Rb.velocity.x, Rb.velocity.y - Sp * 1f);

                    }

                }
            }       
        }
        else
        {
            Rb.velocity = new Vector2(Rb.velocity.x, Rb.velocity.y * um );
            // Rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        }
       
    }


    public void CamMooveX()
    {
       // print(SpX * Time.deltaTime);

        if (CG.gameObject.transform.position.x - XPos - gameObject.transform.position.x > 0.2f)
        {
            
            if (CG.gameObject.transform.position.x - XPos - gameObject.transform.position.x < 1.4f)
            {
               

                Rb.velocity = new Vector2(( SpX), Rb.velocity.y);
                
              
            }
            else
            {
                Rb.velocity = new Vector2(10f, Rb.velocity.y);
            }
        }
        else if (CG.gameObject.transform.position.x - XPos - gameObject.transform.position.x < -0.2f)
        {

            if (CG.gameObject.transform.position.x - XPos - gameObject.transform.position.x > -1.4f)
            {


                Rb.velocity = new Vector2((-SpX), Rb.velocity.y);


            }
            else
            {
                Rb.velocity = new Vector2(-10f, Rb.velocity.y);
            }
        }
        else
        {
            Times = 0f;
            Rb.velocity = new Vector2( Rb.velocity.x * umX , Rb.velocity.y);
            // Rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        }
    }

  
    public void FixedUpdate()
    {
        if (!T)
        {
            T = CG.TD;
            CamMooveY();
            CamMooveX();
            //   
            //  print(Rb.velocity);
         //   print(CG.gameObject.transform.position.y - YPos - gameObject.transform.position.y+" "+ (Rb.velocity));
        }
       // print(Time.deltaTime);
    }
    public void Update()
    {
        if (!T)
        {
           // T = CG.TD;
          //  CamMooveY();
         //  CamMooveX();
            //   
          //  print(Rb.velocity);
            //  print(Rb.velocity);
        }
        Rb.velocity = new Vector2(0f, 0f);
        if ((Input.touches.Length > 0)&&T)
        {
            for (int i = 0; i < Input.touchCount ; i++)
            {


                if (((Input.touches[i].phase == TouchPhase.Began))/*&&Col.bounds.Contains((Input.GetTouch(i).position))*/)
                {
                    
                    PlayerPrefs.SetInt("Vol", OnPauseScr.TrVol ? 1 : 0);
                    Time.timeScale = 1;
                    //OnPauseScr.TrVol = !OnPauseScr.TrVol;
                    PlayerPrefs.Save();
                    Time.timeScale = 1;

                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }


            }
        }
    }
}
