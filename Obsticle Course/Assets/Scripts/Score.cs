using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int playerScore = 0;
    
    private void OnCollisionEnter(Collision other) {
        playerScore++;
        Debug.Log("You hit the wall " + playerScore + " times!");
    }
}
