using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    void OnTriggerEnter(Collider other) /*upon reaching center, player will be taken to "game over" board, which
        is just a fun little playable area*/
    {
        SceneManager.LoadScene(3);
    }
}
