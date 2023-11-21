using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 100.0f;
    public float rot;
    public float rotSpeed;
    
    void Update()
    {
        float transalatez = Input.GetAxis("Vertical") * speed;
        float transalatex = Input.GetAxis("Horizontal") * speed;
       
        transalatex *= Time.deltaTime;
        transalatez *= Time.deltaTime;
        

        rot = Input.GetAxis("See") * rotSpeed * Time.deltaTime;
        Debug.Log(Input.GetAxis("Vertical"));
        
        transform.Translate(transalatex,0, transalatez);
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + rot, 0);
    }
}