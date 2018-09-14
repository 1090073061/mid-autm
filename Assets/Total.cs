using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using UnityEngine.UI;

public class Total : MonoBehaviour
{
    private static System.Random random = new System.Random();
    public GameObject button;
    public int startn = 0;
    public int endn = 0;
    private List<int> narray= new List<int>();
    // Use this for initialization
    void Start()
    {
        int a = startn;
        for (int j = 0; j <endn-startn; j++){
            narray.Add(a);
            a++;
        }

    }
    int Rand(){
        System.Random rand = new System.Random();
        return rand.Next(0, endn-startn);

    }
    static void Shuffle<T>(List<T> arr){

        int n = arr.Count;
        for (int i = 0; i < n;i++){
            int r = i + random.Next(n - i);
            T t = arr[i];
            arr[r] = arr[i];
            arr[i] = t;
        }
    }
   public void Bingo(){
        Shuffle(narray);
        int num = narray[Rand()];
        narray.Remove(num);
        button.GetComponentInChildren<Text>().text = num.ToString();
        for (int i = 0; i < narray.Count; i++){
            print(narray[i]);
        }
    }


	// Update is called once per frame
	void Update () {
		
	}
}
