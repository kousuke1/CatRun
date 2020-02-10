using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    Rigidbody rd;
      float jumpPower = 300.0f;
    // Start is called before the first frame update
    void Start()
    {
       
       this.rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
             this.rd.AddForce(transform.up * this.jumpPower);
            }
    }     
   
    
}
