using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScinUv : MonoBehaviour {
    public bool Vx = false;
    public int Scol;
    public char a='1';
    public GameObject Go,Cam;
    void Start () {
        Vx = ((PlayerPrefs.GetInt("SkinOpen"+a)==1)?true:false);
        Scol=PlayerPrefs.GetInt("skinKol");
        if (Vx)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Scol++;
             PlayerPrefs.SetInt("SkinOpen"+a,1);
             PlayerPrefs.SetInt("skinKol", Scol);
            PlayerPrefs.Save();
            Instantiate(Go, Cam.transform);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
