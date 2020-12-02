using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeScr : MonoBehaviour {
    public ConstantForce2D Cf2d;
  //  public GameObject GG;
	void Start () {
        Cf2d = GetComponent<ConstantForce2D>();

	}
	
	// Update is called once per frame
	void Update () {
        // Cf2d.force = new Vector2(-0.009f,);
       // print(transform.position);
        //print(transform.parent.position);
        if(ConGGScr.YposG>gameObject.transform.position.y)
        {
            Cf2d.force = new Vector2(0.014f,0.003f);
        }
        else
        {
            Cf2d.force = new Vector2(0.014f,-0.003f);
        }
    }
}
