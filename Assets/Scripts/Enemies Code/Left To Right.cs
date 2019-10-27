using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftToRight : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public Transform enemy;
    public int speed;
    bool endP = false;
    bool startP = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // which empty objectg it will move to is set
        if (enemy.position.x >= end.position.x)
        {
            endP = true;
            startP = false;
        }

        if (enemy.position.x <= start.position.x)
        {
            endP = false;
            startP = true;
        }

        //which way the enemy moves
        if (enemy.position.x <= end.position.x && endP == false)
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
        if (enemy.position.x >= start.position.x && startP == false)
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
    }
}
