using UnityEngine;
using System.Collections;

public class flag : MonoBehaviour {
    // Use this for initialization
    bool flagg = true;
    
    ////
    //private AudioSource audioSource;
    //public AudioClip destroysound;
    //
    void Start () {
        //audioSource = GetComponent<AudioSource>();

    }
    // Update is called once per frame
    void Update () {
        //print(score.sum);
	if(flagg && transform.position.y < -10)
        {
            score.sum--;
            flagg = false;
            //audioSource.clip = destroysound;
            //audioSource.Play();

        }
    }
}
