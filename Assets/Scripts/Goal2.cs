﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal2 : MonoBehaviour
{
     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Player"){
            Debug.Log("goal");
            SceneManager.LoadScene("Goal2");
        }
    }
}
