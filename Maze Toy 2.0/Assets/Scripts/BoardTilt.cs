using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//maze design: http://www.banditseries.com/wp-content/uploads/2018/05/MAZE-2-EASY.jpg
//code help from: https://www.youtube.com/watch?v=ma2QGWIo64Y&t=2s (for tilting gameboard)
//https://www.youtube.com/watch?v=Gfq1aB2-qtk (for making "glass" material)

public class BoardTilt : MonoBehaviour
{
    public Vector3 currentRot; //holds information on x,y,z coordinates

    // Update is called once per frame
    void Update()
    {
        currentRot = GetComponent<Transform>().eulerAngles;

        //the numbers determine the max distance the board is able to tilt in that direction

        if ((Input.GetKey(KeyCode.RightArrow))) //pushing right side of board down
        {
            transform.Rotate(0, 0, -1);
        }

        if ((Input.GetKey(KeyCode.LeftArrow))) //pushing left side of board down
        {
            transform.Rotate(0, 0, 1);
        }

        if ((Input.GetKey(KeyCode.DownArrow))) //tilts board back
        {
            transform.Rotate(-1, 0, 0);
        }

        if ((Input.GetKey(KeyCode.UpArrow))) //tilts board forward
        {
            transform.Rotate(1, 0, 0);
        }
    }
}
