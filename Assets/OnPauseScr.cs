using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnPauseScr : MonoBehaviour {
   public static bool TrVol=true;
    public GameObject Obj;
    public ConGGScr ContS;
    public Toggle Tg;
    public PauseScr PS;

    // Use this for initialization
    void Start () {
        // TrVol = PlayerPrefs.GetInt("Vol")==1?true:false;
       // print(OnPauseScr.TrVol);
        //TrVol = !TrVol;
       
    }
    public void res()
    {
        PlayerPrefs.SetInt("Vol", OnPauseScr.TrVol ? 1 : 0);
        Time.timeScale = 1;
       // OnPauseScr.TrVol = !OnPauseScr.TrVol;

        PlayerPrefs.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnEnable()
    {
     //   Tg.isOn = TrVol;
       // OnPauseScr.TrVol = !OnPauseScr.TrVol;

    }

    public void ToMenu()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(0);
    }
    public void Resume()
    {
        Obj.SetActive(false);
        ContS.TrPause = false;
        Time.timeScale =1;
    }
    public void Vol()
    {
        if(PS.Tl)
        {
            print("hui");
           // TrVol = Tg.isOn;
            print(OnPauseScr.TrVol);
            OnPauseScr.TrVol = !OnPauseScr.TrVol;
            PlayerPrefs.SetInt("Vol", TrVol ? 1 : 0);
            PlayerPrefs.Save();
        }

        
     
    }
    // Update is called once per frame
    void Update () {
        

        if (!TrVol)
        {
            AudioListener.volume = 0f;
        }
        else
        {
            AudioListener.volume = 1f;
        }
	}
}
