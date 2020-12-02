using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCube : MonoBehaviour {
    public GameObject Go;
    public BossGr1Scr BGr;
    public bool TrONo = false;
	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
     
        if(collision.gameObject.tag=="Bullet")
        {
            Instantiate(Go, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
            if(!TrONo)
            {
                if(Random.Range(1,4)!=2)
                {
                    BGr.TrJ = true;

                    BGr.TrD = false;
                    BGr.Tdef = false;
                    BGr.TrInA = false;
                    BGr.TrdestroiBlock = false;
                    BGr.TrInA1 = false;
                    BGr.TJ = BGr.TJ1;
                }
                    
                
            }
            else
            {
                BGr.TrD = true;
            }
            Destroy(gameObject);

        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
