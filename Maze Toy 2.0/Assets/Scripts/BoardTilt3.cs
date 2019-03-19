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

        if ((Input.GetKey(KeyCode.RightArrow) && (currentRot.z >= 351 || currentRot.z <= 14)))
        {
            transform.Rotate(0, 0, -1);
        }

        if ((Input.GetKey(KeyCode.LeftArrow)) && (currentRot.z <= 13 || currentRot.z >= 350))
        {
            transform.Rotate(0, 0, 1);
        }

        if ((Input.GetKey(KeyCode.DownArrow)) && (currentRot.z <= 15 || currentRot.z >= 348))
        {
            transform.Rotate(-1, 0, 0);
        }

        if ((Input.GetKey(KeyCode.UpArrow)) && (currentRot.z >= 349 || currentRot.z <= 16))
        {
            transform.Rotate(1, 0, 0);
        }
    }

}
