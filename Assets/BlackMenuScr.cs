using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackMenuScr : MonoBehaviour {
    public SpriteRenderer Sr;
    public float T2 = 1;
    void Start()
    {
        T2 = Random.Range(1, 40) / 2000f;
        gameObject.transform.Rotate(new Vector3(gameObject.transform.rotation.x, gameObject.transform.rotation.y, Random.Range(-60, 60) * 1f));//
    }
    void FixedUpdate()
    {
        Sr.color = new Color(Sr.color.r, Sr.color.g, Sr.color.b, Sr.color.a-T2);
        if (Sr.color.a-T2 <= 0)
        {
            Destroy(gameObject);
        }
    }
    


    /*
    public Animator An;


    // Use this for initialization



    // Update is called once per frame

    }*/
}
