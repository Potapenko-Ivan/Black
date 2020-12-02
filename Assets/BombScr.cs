using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScr : MonoBehaviour {
    public GameObject bullet;
    public bool InTr = false;
    void Start () {
		
	}
	

	void Update () {
		if(InTr)
        {
            Instantiate(bullet,new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.Euler(0, 0,90));
            InTr = false;
        }
	}
}
