using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodScr : MonoBehaviour {
    public static bool Poim=false;
    public bool Vx = false,TrMon=true;
  
  //  public char a = '1';
    public GameObject Go,G2;
    void Start()
    {
      //  Scol = PlayerPrefs.GetInt("GoodCol");
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(Go);

            if(TrMon) ENDScr.LvlScor++;
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Gr"||collision.gameObject.layer==21)
        {

        }
        else
        {
            Instantiate(G2,new Vector2(gameObject.transform.position.x,gameObject.transform.position.y),Quaternion.identity);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
