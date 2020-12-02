using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScrMenu : MonoBehaviour {
    public GameObject Con;
    public InputField IF;
    public int Icol = 0,L=0,Scol;
    public bool OnOpen=false;
    public GameObject Qe,qe2,q;
    public Toggle Tg;
    public Text Txt;
	void Start () {
        Icol=PlayerPrefs.GetInt("IntCol");
        print(OnPauseScr.TrVol);
        OnOpen= PlayerPrefs.GetInt("on") == 1 ? true : false;
        OnPauseScr.TrVol = PlayerPrefs.GetInt("Vol") == 1 ? true : false;
        Tg.isOn = OnPauseScr.TrVol;
        //OnPauseScr.TrVol=false;
        //  print(OnPauseScr.TrVol);
        // Tg.isOn = OnPauseScr.TrVol;
        //print(OnPauseScr.TrVol);
       // Application.targetFrameRate = 300;
        for (int i = 1; i < 14; i++)
        {
            L+=PlayerPrefs.GetInt("Score" + i);
           
        }
        if(L>=5&&!OnOpen)
        {
            PlayerPrefs.SetInt("on", 1);
            Instantiate(q, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
            Scol = PlayerPrefs.GetInt("skinKol");
            PlayerPrefs.SetInt("skinKol", Scol+1);
            PlayerPrefs.Save();
        }
       
    }
    public void ForVlad()
    {
        SceneManager.LoadScene(IF.text);


    }
    public void FPS()
    {
        Application.targetFrameRate = 400;


    }
    public void Update () {

        Txt.text = L.ToString();


        //  Con.gameObject.SetActive(false); 
        if (Icol==0)
        {
            Con.gameObject.SetActive(false);
            PlayerPrefs.SetInt("Scin", 0);
            PlayerPrefs.SetInt("skinKol", 2);
            PlayerPrefs.SetInt("SkinOpen1", 0);
            PlayerPrefs.SetInt("SkinOpen2", 0);
            PlayerPrefs.SetInt("SkinOpen3", 0);
            for (int i = 1; i < 14; i++)
            {
                PlayerPrefs.SetInt("Score" + i, 0);
            }
            PlayerPrefs.SetInt("on", 0);
            PlayerPrefs.SetInt("SkinOpen4", 0);
            PlayerPrefs.SetInt("SkinOpen5", 0);
            PlayerPrefs.SetInt("IntCol", this.Icol);
            PlayerPrefs.Save();
        }

        if ( !OnPauseScr.TrVol)
        {
            AudioListener.volume = 0f;
        }
        else
        {
            AudioListener.volume = 1f;
        }

    }
    public void Vol()
    {
        OnPauseScr.TrVol = Tg.isOn;
        print(OnPauseScr.TrVol);
        PlayerPrefs.SetInt("Vol", OnPauseScr.TrVol ? 1 : 0);
        PlayerPrefs.Save();

    }
    public void Level()
    {
        // SceneManager.LoadScene("1");

        SceneManager.LoadScene("101");

    //    print("H");
    }
    public void Scin()
    {
        SceneManager.LoadScene("105");
       // SceneManager.LoadScene(7);
       // SceneManager.GetSceneByName("105");
        print("H");
    }
    public void ShowNew()
    {
        if(Icol==0)
        {
            Icol = 1;
            PlayerPrefs.SetInt("Scin", 0);
            PlayerPrefs.SetInt("skinKol", 2);
            PlayerPrefs.SetInt("SkinOpen1", 0);
            PlayerPrefs.SetInt("SkinOpen2", 0);
            PlayerPrefs.SetInt("SkinOpen3", 0);
            for (int i = 1; i < 14; i++)
            {
                PlayerPrefs.SetInt("Score" + i, 0);
            }
            PlayerPrefs.SetInt("on", 0);
            PlayerPrefs.SetInt("SkinOpen4", 0);
            PlayerPrefs.SetInt("SkinOpen5", 0);
            PlayerPrefs.SetInt("IntCol", this.Icol);
            PlayerPrefs.Save();
            SceneManager.LoadScene(1);
            print("N");

        }
        else
        {
            Qe.SetActive(true);
            qe2.SetActive(false);
        }
       

    }
    public void Yes()
    {

        Icol = 1;
        PlayerPrefs.SetInt("Scin", 0);
        PlayerPrefs.SetInt("skinKol", 2);
        PlayerPrefs.SetInt("SkinOpen1", 0);
        PlayerPrefs.SetInt("SkinOpen2", 0);
        PlayerPrefs.SetInt("SkinOpen3", 0);
        PlayerPrefs.SetInt("SkinOpen4", 0);
        PlayerPrefs.SetInt("SkinOpen5", 0);
        for(int i=1;i<14;i++)
        {
            PlayerPrefs.SetInt("Score" + i, 0);
        }
        PlayerPrefs.SetInt("on",0);
        PlayerPrefs.SetInt("IntCol", this.Icol);
        PlayerPrefs.Save();
        SceneManager.LoadScene(1);
        print("N");





    }
    public void No()
    {
       
            Qe.SetActive(false);
            qe2.SetActive(true);



    }
    public void ShowC()
    {
        
        SceneManager.LoadScene(Icol);
    }
    void Info()
    {

    }
}
