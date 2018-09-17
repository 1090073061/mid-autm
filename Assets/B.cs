using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.UI;

public class B : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //print("c" + String.Join(",", Total.narray.Select(x => x.ToString()).ToArray()));
        //for (int i = 0; i < 5; i++)
        //{
        //    print(Total.narray[i]);
        //}
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                    print("c" + String.Join(",", Total.narray.Select(x => x.ToString()).ToArray()));
                    for (int i = 1; i < 6; i++){
                    print(Total.narray[i-1]);
                    int num = Total.narray[i - 1];
                    GameObject.Find(i.ToString()).GetComponentInChildren<Text>().text = num.ToString(); ;
                    Total.narray.RemoveAt(i-1);
                    }
                }
        print("d" + String.Join(",", Total.narray.Select(x => x.ToString()).ToArray()));

    }
        }
    

