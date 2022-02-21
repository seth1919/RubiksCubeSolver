using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMovement : MonoBehaviour
{
    public float movementSpeed;
    public float distance;
    float theta = 1.5708f;
    float phi = 1.5708f;

    public Transform camera;
    public Transform cube;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        //add mouse x to theta
        theta = theta + (Input.GetAxis("Mouse X") * Time.deltaTime * movementSpeed * -1);
        //add mouse y to phi
        if (phi + (Input.GetAxis("Mouse Y") * Time.deltaTime * movementSpeed) > 0.1 && phi + (Input.GetAxis("Mouse Y") * Time.deltaTime * movementSpeed) < 3.0)
        {
            phi = phi + (Input.GetAxis("Mouse Y") * Time.deltaTime * movementSpeed);
        }
        //convert thera and phi to cartesian coordinates
        float x = distance * Mathf.Sin(phi) * Mathf.Cos(theta);
        float y = distance * Mathf.Sin(phi) * Mathf.Sin(theta);
        float z = distance * Mathf.Cos(phi);
        //move the camera to these coordinates
        camera.position = new Vector3(x, z, y);
        //rotate the camera to face the cube
        camera.rotation = Quaternion.identity;
        camera.LookAt(cube, Vector3.up);
    }
}
