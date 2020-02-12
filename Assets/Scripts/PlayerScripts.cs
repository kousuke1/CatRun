using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScripts : MonoBehaviour
{
      public static float speed = 15.0f;
    Rigidbody rd;
      float jumpPower = 600.0f;
    // Start is called before the first frame update
    void Start()
    {
       
       this.rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      Vector2 Position = transform.position;

        
       transform.position += transform.right * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
            {
             this.rd.AddForce(transform.up * this.jumpPower);
              
            }


    }     

   
    
}
