using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print("Welcome to cubex");
    }

    // Update is called once per frame
    void Update()
    {
    //    print("This is a world of cubes");

       var h = Input.GetAxis("Horizontal");
       var v = Input.GetAxis("Vertical");

       var newX = h * Time.deltaTime;
       var newY = 0f * Time.deltaTime;
       var newZ = v * Time.deltaTime;

       transform.Translate(newX, newY, newZ); 
    }
}
