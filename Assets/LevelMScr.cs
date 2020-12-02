using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelMScr : MonoBehaviour {
    public GameObject[] GObj = new GameObject[21];
    public Button[] B = new Button[21];
    public int Icol;

    void Start()
    {
        Icol = PlayerPrefs.GetInt("IntCol");
        print(OnPauseScr.TrVol);
        OnPauseScr.TrVol = PlayerPrefs.GetInt("Vol") == 1 ? true : false;
        print(Icol);
    }
    

    void Update() {
        for (int i = 0; i <( Icol>21?21: Icol); i++)
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
        SceneManager.LoadScene(1);
    }
    public void A2()
    {
        SceneManager.LoadScene(2);
    }
    public void A3()
    {
        SceneManager.LoadScene(3);
    }
    public void A4()
    {
        SceneManager.LoadScene(4);
    }
    public void A5()
    {
        SceneManager.LoadScene(5);
    }
    public void A6()
    {
        SceneManager.LoadScene(6);
    }
    public void A7()
    {
        SceneManager.LoadScene(7);
    }
    public void A8()
    {
        SceneManager.LoadScene(8);
    }
    public void A9()
    {
        SceneManager.LoadScene(9);
    }
    public void A10()
    {
        SceneManager.LoadScene(10);
    }
    public void A11()
    {
        SceneManager.LoadScene(11);
    }
    public void A12()
    {
        SceneManager.LoadScene(12);
    }
    public void A13()
    {
        SceneManager.LoadScene(13);
    }
    public void A14()
    {
        SceneManager.LoadScene(14);
    }
    public void A15()
    {
        SceneManager.LoadScene(15);
    }
    public void A16()
    {
        SceneManager.LoadScene(16);
    }
   
    public void A17()
    {
        SceneManager.LoadScene(17);
    }
    public void A18()
    {
        SceneManager.LoadScene(18);
    }
    public void A19()
    {
        SceneManager.LoadScene(19);
    }
    public void A20()
    {
        SceneManager.LoadScene(20);
    }
    public void A21()
    {
        SceneManager.GetSceneByName("102");
    }
    public void M()
    {
        SceneManager.LoadScene(0);
    }

}
