using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;


public class Rand : MonoBehaviour {
    public GameObject button;
    // Use this for initialization
    void Start () {
        //print("new " + String.Join(",",Total.Bingo().Select(x => x.ToString()).ToArray()));

    }
    public void Remove_first(){
        int num = Total.Bingo()[0];
        button.GetComponentInChildren<Text>().text = num.ToString();
        Total.Bingo().Remove(num);
        //print("removed first " + String.Join(",", Total.Bingo().Select(x => x.ToString()).ToArray()));
    }
	// Update is called once per frame
    void Update () {
    }
}
