using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelMScr : MonoBehaviour {
    public Rigidbody2D Rb;
    public ConstantForce2D Cf;
    public float z;
    public bool Tr = false;
    public GameObject GO;
	void Start () {
        GO = GameObject.FindWithTag("RelM");//..GetComponent<GameObject>();
        gameObject.transform.position = new Vector2(GO.transform.position.x, GO.transform.position.y);
        Cf.torque = Random.Range(-2,2)*20;
	}
 
   
    
    void Update () {
	
	}
}
