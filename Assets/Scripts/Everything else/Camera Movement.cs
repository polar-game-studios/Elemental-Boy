
//This makes the camera move up on its own for the air world
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// move camera independantly 
public class CameraMovment : MonoBehaviour

{

    public Transform maincamera;
    public Transform endpoint;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (maincamera.position.y < endpoint.position.y)
        {
            transform.position += Vector3.up * Time.deltaTime / 3;
        }
    }
}
