using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScinUved : MonoBehaviour {
    public float T = 0.6f, Sp = 0.1f;
	
	void Start () {
		
	}
	
	
	void Update () {
        T -= Time.deltaTime;
        if(T<=0)
        {
            Destroy(gameObject);
        }
	}
    private void FixedUpdate()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + Sp);
    }
}
