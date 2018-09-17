using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

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
                    for (int i = 0; i < 5; i++){
                        print(Total.narray[i]);
                        Total.narray.RemoveAt(i);
                    }
                }
        print("d" + String.Join(",", Total.narray.Select(x => x.ToString()).ToArray()));

    }
        }
    

