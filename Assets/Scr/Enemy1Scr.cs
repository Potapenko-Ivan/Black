using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Scr : MonoBehaviour {

    public GameObject GGVZ,Bullet, Bullet2,Exp;
    public ConGGScr CG;
    public float T,t2=6f;
    public bool TrR = false;
	void Start () {
        CG = GameObject.FindWithTag("Player").GetComponent<ConGGScr>();
        if(Random.Range(0,1)==0)
        {
            TrR = true;
        }
    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(GGVZ, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0f), Quaternion.identity, gameObject.transform.parent);
            Instantiate(Exp, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0f), Quaternion.identity, gameObject.transform.parent);

            Destroy(this.gameObject);
        }
    }
    void Update () {

        if (TrR)
        {
            transform.rotation = new Quaternion(0f, 0f, 0f, 0f);

        }
        else
        {
            transform.rotation = new Quaternion(0f, 180f, 0f, 0f);

        }
        if(T<=0)
        {
            Instantiate(Bullet, gameObject.transform);
            Instantiate(Bullet2, gameObject.transform);
            T = t2;
        }
        else
        {
            T -= Time.deltaTime;
        }
    }
}
