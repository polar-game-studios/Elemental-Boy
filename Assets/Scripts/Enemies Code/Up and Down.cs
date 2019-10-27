using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigUp : MonoBehaviour
{

    public Transform enemy;
    public Transform end;
    public Transform start;
    public int speed;
    bool endP = true;
    bool startP = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.position.y <= end.position.y || enemy.position.y >= start.position.y)
        {

            //what point the pig will go to
            if (enemy.position.y >= end.position.y)
            {
                startP = false;
                endP = true;
            }
            if (enemy.position.y <= start.position.y)
            {
                endP = false;
                startP = true;
            }

        }
        //pig movment
        if (enemy.position.y < end.position.y && endP == false)
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }


        if (enemy.position.y > start.position.y && startP == false)
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }



    }
}
