using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Re : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            int num = Total.narray[0];
            GameObject.Find("Button").GetComponentInChildren<Text>().text = num.ToString(); 
            Total.narray.RemoveAt(0);
        }
	}
}
