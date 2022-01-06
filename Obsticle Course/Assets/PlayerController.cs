using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // [SerializeField] float xValue = 0;
    // [SerializeField] float yValue = 0.01f;
    // [SerializeField] float zValue = 0;

    [SerializeField] float playerSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        ShowDebugControls();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void ShowDebugControls()
    {
        Debug.Log("Move with WASD");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed;
        
        transform.Translate(xValue, 0, zValue);
    }
}
