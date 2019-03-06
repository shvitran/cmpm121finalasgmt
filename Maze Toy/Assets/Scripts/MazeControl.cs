using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeControl : MonoBehaviour
{
    public float minRotation; //Needs to be within a range of 0 and 85
    public float maxRotation; //Needs to be within a range of 0 and -85

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //placeholder code to move gameboard
    //got this code from online: https://answers.unity.com/questions/235545/tilt-gameboard.html
    // Update is called once per frame
    void Update()
    {

        float horRot = (Input.GetAxis("Horizontal")) * Time.deltaTime * -20;
        float vertRot = (Input.GetAxis("Vertical")) * Time.deltaTime * 20;

        float totalHorRot;
        float totalVertRot;

        if (transform.eulerAngles.x + horRot < 350)
        {
            totalHorRot = transform.eulerAngles.x + horRot;
        }
        else
        {
            totalHorRot = transform.eulerAngles.x + horRot - 360;
        }

        if (transform.eulerAngles.z + vertRot < 350)
        {
            totalVertRot = transform.eulerAngles.z + vertRot;
        }
        else
        {
            totalVertRot = transform.eulerAngles.z + vertRot - 360;
        }

        transform.rotation = Quaternion.Euler(Mathf.Clamp(totalHorRot, -8f, 8f), 0, Mathf.Clamp(totalVertRot, -8f, 8f));
    }
}
