using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.UI;
using System.Threading;

public class B : MonoBehaviour
{
    private bool isPress = false;

    private bool signal = false;
    public GameObject button;
    int num;
    // Use this for initialization
    void Start()
    {
        //print("c" + String.Join(",", Total.narray.Select(x => x.ToString()).ToArray()));
        //for (int i = 0; i < 5; i++)
        //{
        //    print(Total.narray[i]);
        //}
    }
    //void Gif(){

    //}


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPress = !isPress;
        }
        if (isPress)
        {
            signal = true;
            Total.Bingo();
            num = Total.narray[0];
            button.GetComponentInChildren<Text>().text = num.ToString(); ;
            //for (int i = 1; i < 6; i++)
            //{
            //    Total.Bingo();
            //    int num = Total.narray[i - 1];
            //    GameObject.Find(i.ToString()).GetComponentInChildren<Text>().text = num.ToString(); ;
            //}
        }
        else
        {
            if (signal)
            {
                Total.narray.Remove(num);
                signal = false;
                print("final: " + String.Join(",", Total.narray.Select(x => x.ToString()).ToArray()));
                //for (int i = 1; i < 6; i++)
                //{
                //    int num = Total.narray[i - 1];
                //    GameObject.Find(i.ToString()).GetComponentInChildren<Text>().text = num.ToString(); ;
                //    Total.narray.RemoveAt(i - 1);
                //    print(i - 1);
                //}
            }
        }

    }
}

