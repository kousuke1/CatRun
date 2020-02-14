using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PintVewScripts : MonoBehaviour
{
    public GameObject PointText = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int points = PointScripts.Point;
        Text Pt = PointText.GetComponent<Text> ();
        Pt.text = "Score:" + points;

    }

}
