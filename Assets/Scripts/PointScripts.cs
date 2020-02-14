using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PointScripts : MonoBehaviour
{
     public static int Point = 0;

    
    // Start is called before the first frame update
    void Start()
    {
     Point = 0;
    }

    // Update is called once per frame
    void Update()
    {

       
    }

    void OnCollisionEnter(Collision collision){

        if(collision.gameObject.tag == "Coin"){
            Point = Point + 1;
            Debug.Log(Point);
        }
        if(collision.gameObject.tag == "Brock"){
            Point = Point - 3;
            Debug.Log(Point);
        }

    }
}
