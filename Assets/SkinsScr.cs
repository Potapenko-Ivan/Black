using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkinsScr : MonoBehaviour {
    public Sprite[] Scins = new Sprite[6];
    public SpriteRenderer Sr;
    public SpriteMask Sm;
    public int ScinNum;

	// Use this for initialization
	void Start () {
        ScinNum = PlayerPrefs.GetInt("Scin");
        Sr.sprite = Scins[ScinNum];
        Sm.sprite = Scins[ScinNum];

        //PlayerPrefs.SetInt("Scin", OnPauseScr.TrVol ? 1 : );
        //PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
