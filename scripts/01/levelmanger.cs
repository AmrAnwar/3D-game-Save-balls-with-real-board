using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelmanger : MonoBehaviour {

    // Use this for initialization
    public Text lose_text1;
    public Text lose_text2;
    static bool flag_2 = false;
    //
    private AudioSource audioSource;

    public AudioClip destroysound;
    //
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0))
        {
            score.score1 = 0;
            score.sum = 3;
            load_next();
        }
        if (flag_2)
        {
            text_lose();
            flag_2 = false;
        }
    }
    void load_next()
    {
        //load scene 02_Game 
        int current = SceneManager.GetActiveScene().buildIndex;
        //load current +1
        SceneManager.LoadScene(current + 1);
    }
    public static void load_index(int c)
    {
        SceneManager.LoadScene(c);


    }
    public   void text_lose()
    {
        audioSource.clip = destroysound;
        audioSource.Play();

        lose_text1.text ="Your Score: "+ score.score1 +"\n \nYou are !! : \n \n" + " \n \n\npress to play again ";
        lose_text2.text = score.level.ToString();
    }
    public static void lose() {

        load_index(0);
        flag_2 = true;
    }


}


