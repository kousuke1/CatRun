using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PointScripts : MonoBehaviour
{

    public static int Point = 0;


    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        
       
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

    }
}
