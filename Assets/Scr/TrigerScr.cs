using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerScr : MonoBehaviour {
   
    public StEnemyScr SS;
	void Start () {
		
	}
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SS.TR = true;
        }
    }
    void Update () {
		
	}
}
