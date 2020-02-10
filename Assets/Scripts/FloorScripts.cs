using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScripts : MonoBehaviour
{
    public float speed = 15.0f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
     Vector2 Position = transform.position;

        
       transform.position -= transform.right * speed * Time.deltaTime;
    }

}
