using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour {

    public Rigidbody2D rb;
    public float Sp=6f,Angle;
	void Start () {
        Angle =gameObject.transform.eulerAngles.z;
     //  print(Angle);
       // gameObject.transform.rotation = new Quaternion(0f,0f,0f,gameObject.transform.rotation.w);// new Vector3(0f, 0f, 0f);
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "LWall" || collision.gameObject.tag == "Gr")
        {
            Destroy(gameObject);

        }   

    }
    // Update is called once per frame
    void Update () {
        rb.velocity = new Vector2(Mathf.Sin(Mathf.Deg2Rad*Angle) * Sp, Mathf.Cos(Mathf.Deg2Rad * Angle) * -Sp);
	}
}
