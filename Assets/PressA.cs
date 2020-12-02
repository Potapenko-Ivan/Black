using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressA : MonoBehaviour {
    public GameObject GObj;
    public ENDScr EndS;
    public CamNewPos CNP;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(CNP.T||EndS.TrEnd)
        {
            GObj.gameObject.SetActive(true);
        }
	}
}
