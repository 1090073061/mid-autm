using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;



public class Total : MonoBehaviour
{
    private static System.Random random = new System.Random();
    //public GameObject button;
    public static int startn = 1;
    public static int endn = 20;
    public static List<int> narray= new List<int>();
    // Use this for initialization

    void Start()
    {
        int a = startn;
        for (int j = 0; j <endn-startn; j++){
            narray.Add(a);
            a++;
        }
        print("b" +String.Join(",", narray.Select(x=>x.ToString()).ToArray()));
        Shuffle(narray);

    }
    int Rand(){
        System.Random rand = new System.Random();
        int a = rand.Next(0, endn-startn);
        endn--;
        return a;


    }
    static void Shuffle<T>(List<T> arr){

        int n = arr.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = arr[k];
                arr[k] = arr[n];
                arr[n] = value;
            }
    }
    public static List<int> Bingo(){
        Shuffle(narray);
        return narray;
        //int num = narray[0];
        //narray.RemoveAt(0);
        //print("a" + String.Join(",", narray.Select(x => x.ToString()).ToArray()));
        //button.GetComponentInChildren<Text>().text = num.ToString();
    }



	// Update is called once per frame
	void Update () {
		
	}
}
