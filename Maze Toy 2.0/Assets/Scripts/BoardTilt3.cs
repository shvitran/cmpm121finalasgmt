using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//maze design: http://www.banditseries.com/wp-content/uploads/2018/05/MAZE-2-HARD.jpg

public class BoardTilt3 : MonoBehaviour
{
    public Vector3 currentRot; //repeat of code from Maze 1 and 2

    // Update is called once per frame
    void Update()
    {
        currentRot = GetComponent<Transform>().eulerAngles;

        if ((Input.GetKey(KeyCode.RightArrow)))
        {
            transform.Rotate(0, 0, -1);
        }

        if ((Input.GetKey(KeyCode.LeftArrow)))
        {
            transform.Rotate(0, 0, 1);
        }

        if ((Input.GetKey(KeyCode.DownArrow)))
        {
            transform.Rotate(-1, 0, 0);
        }

        if ((Input.GetKey(KeyCode.UpArrow)))
        {
            transform.Rotate(1, 0, 0);
        }
    }

}
