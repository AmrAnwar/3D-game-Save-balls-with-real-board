using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

    // Use this for initialization
    public GameObject new_ball;
    //
    //private AudioSource audioSource;

    //public AudioClip destroysound;
    float star;
    void Start()
    {
       // audioSource = GetComponent<AudioSource>();
        star = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        float t = (Time.time - star) % 60;
        if (t > 5) {

            //audioSource.clip = destroysound;
            //audioSource.Play();

            //ball_s.GetComponent<AudioSource>().Play();
            GameObject go = Instantiate(new_ball);
            go.transform.position = new Vector3(-3, 13, -13);
            star = Time.time;
        }
        
         
    }
}
