using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SledScr : MonoBehaviour {

    public SpriteRenderer SR;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (SR.color.a <= 0.3f)
        {
            Destroy(gameObject);
        }
        SR.color = new Color(SR.color.r, SR.color.g, SR.color.b, SR.color.a / ((Time.deltaTime + 1f)*2f));
        
	}
}
