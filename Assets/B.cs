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

    }
  

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

        }
        else
        {
            if (signal)
            {
                Total.narray.Remove(num);
                signal = false;

            }
        }

    }
}

