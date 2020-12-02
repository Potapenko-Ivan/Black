using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ENDScr : MonoBehaviour {
    public bool TrEnd=false,TrA=false;
    public GameObject[] GObj = new GameObject[3];
    public float j = 3,T,t3=3f;
    public ConGGScr CS;
    public static int LvlScor=0;
    public int Icol = 0,Score;
    //  public AudioSource AS;

    void Start () {
        Icol = PlayerPrefs.GetInt("IntCol");
        print(Icol);
        T = t3;
        LvlScor = 0;
       

    }
	
	void  FixedUpdate () {
        if(TrEnd)
        {
            


            CS.MR = false;
            CS.ML = false;
            if ((Input.touches.Length > 0))
            {
                for (int i = 0; i < Input.touchCount; i++)
                {


                    if (((Input.touches[i].phase == TouchPhase.Began))/*&&Col.bounds.Contains((Input.GetTouch(i).position))*/)
                    { int k;
                        int.TryParse(SceneManager.GetActiveScene().name, out k);
                        Icol = PlayerPrefs.GetInt("IntCol");
                        if(!(Icol >k))
                        {
                            Icol++;
                        }
                        print(k);
                        Score =PlayerPrefs.GetInt("Score" + k);
                        if(Score< LvlScor)
                        {
                            PlayerPrefs.SetInt("Score" + k, LvlScor);

                        }


                        PlayerPrefs.SetInt("Vol", OnPauseScr.TrVol ? 1 : 0);
                        PlayerPrefs.SetInt("IntCol", this.Icol);
                        PlayerPrefs.Save();
                        if (!(Icol-1 > k))
                        {
                            SceneManager.LoadScene(Icol);
                        }
                        else
                        {
                            SceneManager.LoadScene(k+1);
                        }
                       
                       
                    }


                }
            }
            if (T<=0 && !TrA)
            {
            //    AS.Play();
                for (int i = 0; i < j; i++)
                {
                    GObj[i].gameObject.SetActive(true);
                }
                TrA = true;
                T = t3;
            }
            else if(T<=0 && TrA)
            {
                for (int i = 0; i < j; i++)
                {
                    GObj[i].gameObject.SetActive(false);
                }
                TrA = false;
                T = t3;
            }
            T -= 1;

        }

	}
}
