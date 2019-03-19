using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//help on changing scenes: https://www.youtube.com/watch?v=9lPCv9kkbSI

public class SceneChange : MonoBehaviour
{

    void OnTriggerEnter(Collider other) //when ball touches invisible cube, it will automatically change to next level, Maze 2
    {
        SceneManager.LoadScene(1);
    }
}
