using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss2Scr : MonoBehaviour {
    public GameObject GoVz;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Bullet")
        {
            Instantiate(GoVz);
            Destroy(gameObject);
        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
