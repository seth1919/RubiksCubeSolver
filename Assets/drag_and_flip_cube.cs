using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drag_and_flip_cube : MonoBehaviour
{
    public camMovement camMovement1;
    public GameObject[] arrows;
    bool isRotating = false;
    public cubeControl theCube;
    public int mode;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //get the object pointed to by the mouse
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (mode == 6)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(ray, out hit, 100))
                {
                    //if the object is the cube, enable cam Movement
                    if (hit.transform.gameObject.tag == "cube")
                    {
                        //enable cam Movement
                        camMovement1.enabled = true;
                        //if there is no current solve, disable the arrows
                        if (theCube.isSolving != true)
                        {
                            for (int i = 0; i < 12; i++)
                            {
                                arrows[i].SetActive(false);
                            }
                        }

                        isRotating = true;
                        //hide cursor
                        Cursor.lockState = CursorLockMode.Locked;
                    }

                    //if the object is an arrow, get it's spin component and call spin()
                    if (hit.transform.gameObject.tag == "arrow")
                    {
                        (hit.transform.gameObject.GetComponent<spinScript>()).spin();
                    }
                }
            }
            if (Input.GetMouseButtonUp(0))
            {
                camMovement1.enabled = false;
                if (isRotating == true)
                {
                    // if there is no current solve, enable the arrows
                    if (theCube.isSolving != true)
                    {
                        for (int i = 0; i < 12; i++)
                        {
                            arrows[i].SetActive(true);
                        }
                    }
                    isRotating = false;
                }
                //show the cursor
                Cursor.lockState = CursorLockMode.None;
            }
        }
        else if (mode != -1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                int layer_mask = LayerMask.GetMask("square");
                if (Physics.Raycast(ray, out hit, 100, layer_mask))
                {
                    Debug.Log("changing color");
                    //Debug.Log("hit square");
                    //get that square's cube color index
                    int squareIndex = hit.transform.gameObject.GetComponent<squareIndexScript>().squareIndexInt;

                    //set theCube.colors[] = mode;
                    theCube.theCube.colors[squareIndex] = mode;
                    theCube.updateColors();
                }
            }
        }
    }
}
