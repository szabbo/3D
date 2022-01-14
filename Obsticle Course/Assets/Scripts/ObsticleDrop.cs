using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleDrop : MonoBehaviour
{
    MeshRenderer myMR;
    Rigidbody myRB;
    [SerializeField] float dropDelay = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        myMR = GetComponent<MeshRenderer>();
        myMR.enabled = false;

        myRB = GetComponent<Rigidbody>();
        myRB.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropDelay)
        {
            myMR.enabled = true;
            myRB.useGravity = true;
        }
    }
}
