using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScChScr : MonoBehaviour {
    public GameObject[] GObj = new GameObject[21];
    //public Button[] B = new Button[21];
    public int Icol;
    public int ScinNum;
    


    void Start()
    {
        // ScinNum = PlayerPrefs.GetInt("Scin");


        //PlayerPrefs.SetInt("Scin", OnPauseScr.TrVol ? 1 : );
        //PlayerPrefs.Save();
        Icol = PlayerPrefs.GetInt("skinKol");
    }


    void Update()
    {
        for (int i = 0; i < Icol ; i++)
        {
            GObj[i].SetActive(true);
        }
        if (!OnPauseScr.TrVol)
        {
            AudioListener.volume = 0f;
        }
        else
        {
            AudioListener.volume = 1f;
        }

    }
    public void A1()
    {
        ScinNum = 0;
    }
    public void A2()
    {
        ScinNum = 1;
    }
    public void A3()
    {
        ScinNum = 2;
    }
    public void A4()
    {
        ScinNum = 3;
    }
    public void A5()
    {
        ScinNum = 4;
    }
    public void A6()
    {
        ScinNum = 5;
    }
    public void A7()
    {
        ScinNum = 6;
    }
    public void M()
    {
        PlayerPrefs.SetInt("Scin",ScinNum);
        PlayerPrefs.Save();
        SceneManager.LoadScene(0);

    }

}
