using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void OnClick(){
       int points = PointScripts.Point;
       Debug.Log(points);
        if(points >= 10){
            SceneManager.LoadScene("2");
        }else{
            SceneManager.LoadScene("main");
        }
    }
}
