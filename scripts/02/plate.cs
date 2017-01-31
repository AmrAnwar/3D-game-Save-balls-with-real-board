using UnityEngine;
using System.Collections;
//using System.IO.Ports;

public class plate : MonoBehaviour {
    //SerialPort stream = new SerialPort("COM3", 9600); //Set the port (com3) and the baud rate (9600, is standard on most devices)
    //string[] vec3;
    // Use this for initialization
    void Start () {
        //stream.Open();
    }

    // Update is called once per frame
    void Update () {
        //string value = stream.ReadLine(); //Read the information

        //vec3 = value.Split(','); //My arduino script returns a 3 part value
        //vec3[0] == x ,, / vec3[1] == y in arduino
        //float z = float.Parse(vec3[0]);
        //float x = float.Parse(vec3[1]);
        //transform.rotation = Quaternion.Euler(x * -1, 0, z * -1);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.rotation = Quaternion.Euler(mouseY, 0, mouseX) * transform.rotation;


    }
}
