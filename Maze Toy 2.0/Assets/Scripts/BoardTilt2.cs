using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//maze design: http://www.banditseries.com/wp-content/uploads/2018/05/MAZE-2-MEDIUM.jpg

public class BoardTilt2 : MonoBehaviour
{
    public Vector3 currentRot; //using same code from 1st maze for consistency in limiting rotation

    // Update is called once per frame
    void Update()
    {
        currentRot = GetComponent<Transform>().eulerAngles;

        if ((Input.GetKey(KeyCode.RightArrow) && (currentRot.z >= 351 || currentRot.z <= 14))) //tilts board to right
        {
            transform.Rotate(0, 0, -1);
        }

        if ((Input.GetKey(KeyCode.LeftArrow)) && (currentRot.z <= 13 || currentRot.z >= 350)) //tilts board to left
        {
            transform.Rotate(0, 0, 1);
        }

        if ((Input.GetKey(KeyCode.DownArrow)) && (currentRot.z <= 15 || currentRot.z >= 348)) //tilts board back
        {
            transform.Rotate(-1, 0, 0);
        }

        if ((Input.GetKey(KeyCode.UpArrow)) && (currentRot.z >= 349 || currentRot.z <= 16)) //tilts board forward
        {
            transform.Rotate(1, 0, 0);
        }
    }
}
