using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScr : MonoBehaviour {
    public GameObject Go1, Go2, Go3, Go4, Go5, Go6;
    public int K;
    public bool T = true;
	void Start () {
        K = Random.Range(1, 4);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Bullet"&&T)
        {
            T = false;
            if(K==1)
            {
                Instantiate(Go1, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
                print("k1");
            }
            if (K == 2)
            {
                Instantiate(Go2, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
                print("k2");

            }
            if (K == 3)
            {
                Instantiate(Go3, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
                print("k3");

            }
            if (K == 4)
            {
                Instantiate(Go4, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
                print("k4");

            }
            Instantiate(Go6, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);

            Instantiate(Go5, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
            Destroy(gameObject);
        }
    }
    void Update () {
		
	}
}
