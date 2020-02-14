using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrockScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public static int Point = 0;
    public GameObject Player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnCollisionEnter(Collision collision){   
            if(collision.gameObject.tag == "Player"){
                Debug.Log("tomatta?");
                Player.GetComponent<PlayerScripts>().enabled = false;
                StartCoroutine(col());
            }
          }


      private  IEnumerator col(){ //コルーチン関数の名前
        Debug.Log("koruuuuuuutin");
        //コルーチンの内容
        yield return new WaitForSeconds( 2f );
        Player.GetComponent<PlayerScripts>().enabled = true;
        this.gameObject.SetActive(false);
        Debug.Log("Reスタート");
        }
        
        
}
