using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTilt : MonoBehaviour
{
    public Vector3 currentRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
