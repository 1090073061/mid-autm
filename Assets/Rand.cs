using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rand : MonoBehaviour
{
    public int startn = 0;
    public int endn = 0;
    private ArrayList narray= new ArrayList();
    // Use this for initialization
    void Start()
    {
        int a = startn;
        for (int j = 0; j <endn-startn; j++){
            narray.Add(a);
            a++;
            print(narray[j]);
        }
        
    }
    public void rand(){

    }


	// Update is called once per frame
	void Update () {
		
	}
}
