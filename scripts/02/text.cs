using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class text : MonoBehaviour {

    // Use this for initialization

    public Text score1;
    public Text health;
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        score1.text = "Score : " + score.score1.ToString();
        health.text = "Health: " + score.sum.ToString();
    }

}
