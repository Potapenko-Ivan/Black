using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GGVZScr : MonoBehaviour {
    
    public float F = 2f;
    public float z;
    public ConGGScr CS;

    //public GameObject GO;
    void Start()
    {
      CS = GameObject.FindWithTag("Player").GetComponent<ConGGScr>();

        gameObject.transform.position = new Vector2(CS.gameObject.transform.position.x, CS.gameObject.transform.position.y);
    }

    void Update () {
		
	}
}
