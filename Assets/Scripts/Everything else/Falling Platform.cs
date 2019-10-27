using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{

    public Rigidbody pltForm;
    public float playerTime = 0.0f;
    public bool playerStep = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter()
    {
        playerStep = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerStep)
        {
            playerTime += Time.deltaTime;
            if (playerTime > 3.0)
                GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
