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
<<<<<<< HEAD
=======
    private bool signal = false;
    public GameObject button;
    int num;
>>>>>>> random animation
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
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.B))
        {
            while (true){
                for (int i = 1; i < 6; i++)
                {
                    System.Random rand = new System.Random();
                    int a = rand.Next(Total.startn, Total.endn);
                    print(Total.narray[i - 1]);
                    int b = Total.narray[a];
                    GameObject.Find(i.ToString()).GetComponentInChildren<Text>().text = b.ToString();
                }
                Thread.Sleep(100);
                if (Input.GetKeyDown(KeyCode.B)){
                    break;
                }
            }
            if (Input.GetKeyDown(KeyCode.C)){
            print("c" + String.Join(",", Total.narray.Select(x => x.ToString()).ToArray()));
            for (int i = 1; i < 6; i++)
            {
                print(Total.narray[i - 1]);
                int num = Total.narray[i - 1];
                GameObject.Find(i.ToString()).GetComponentInChildren<Text>().text = num.ToString();
                Total.narray.RemoveAt(i - 1);
            }
        }
    }

     }

        //print("d" + String.Join(",", Total.narray.Select(x => x.ToString()).ToArray()));
}
        
    
=======
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
        //if (Input.GetKeyDown(KeyCode.B) || isPress)
        //{
        //    isPress = !isPress;
        //    if(isPress){
        //        for (int i = 1; i < 6; i++)
        //        {
        //            print(Total.narray[i - 1]);
        //            int num = Total.narray[i - 1];
        //            GameObject.Find(i.ToString()).GetComponentInChildren<Text>().text = num.ToString(); ;
        //        }
        //    }
        //    if(!isPress)
        //    {
        //        print("c" + String.Join(",", Total.narray.Select(x => x.ToString()).ToArray()));
        //        for (int i = 1; i < 6; i++)
        //        {
        //            print(Total.narray[i - 1]);
        //            int num = Total.narray[i - 1];
        //            GameObject.Find(i.ToString()).GetComponentInChildren<Text>().text = num.ToString(); ;
        //            Total.narray.RemoveAt(i - 1);
        //        }
        //    }

        //}
        //print("d" + String.Join(",", Total.narray.Select(x => x.ToString()).ToArray()));

    }
}

>>>>>>> random animation

