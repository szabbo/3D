using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleLeftRight : MonoBehaviour
{
    [SerializeField] float obsticleSpeed = 0.5f;
    Transform myT;
    // Start is called before the first frame update
    void Start()
    {
        myT = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        myT.Translate(obsticleSpeed, 0, 0);
    }
}
