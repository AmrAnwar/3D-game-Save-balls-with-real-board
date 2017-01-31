using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

    // Use this for initialization
    float start1;
    public static int  score1;
    public static  int sum=3;
    public  int healthy ;
    public static string level= "Really NOOB";

 
    void Start () {
        start1 = Time.time;
        // sum = 1;

    }

    // Update is called once per frame
    void Update () {
        healthy = sum;
         score1 = (int)(((Time.time - start1) % 60 )* .5 )  ;
        if (score1 > 30)
        {
            level = " professional ";
        }
        else if (score1> 20)
        {
            level = "Great";
        }
        else if(score1 > 10)
        {
            level = " Not Bad";
        }
        //check_lose();
        
    }
    //void check_lose()
    //{
    //    if (sum == 0)
    //    {
     

    //        //
    //        levelmanger.lose();
    //    }
    //}
}
