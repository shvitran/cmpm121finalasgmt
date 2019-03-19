using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange2 : MonoBehaviour
{

    void OnTriggerEnter(Collider other) //when ball touches cube in center of maze, will change scene to Level 3, Maze 3
    {
        SceneManager.LoadScene(2);
    }
}
