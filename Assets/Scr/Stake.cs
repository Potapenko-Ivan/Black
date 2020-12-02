using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stake : MonoBehaviour {
    public ConGGScr CS;
    // Use this for initialization
    void Start () {
        CS = GameObject.FindWithTag("Player").GetComponent<ConGGScr>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "Player")
        {
            CS.TD = true;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
