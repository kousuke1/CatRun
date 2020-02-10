using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultScripts : MonoBehaviour
{
    public GameObject PointText = null;
  
    // Start is called before the first frame update
    void Start()
    {
        
         int  result = PointScripts.Point;
        Debug.Log(result);
         
    }

    // Update is called once per frame
    void Update()
    {
       Text resulttext = PointText.GetComponent<Text> ();
       resulttext.Text = "Score:" + result;

     
     
    }
}

