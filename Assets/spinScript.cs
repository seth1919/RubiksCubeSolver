using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spinScript : MonoBehaviour
{
    public CubeTrigger thisSide;
    public GameObject thisSideObject;
    private GameObject[] children;

    public bool isRotating = false;
    float rotateDistance = 0.0f;
    public float rotateSpeed = 1.0f;
    public MeshCollider[] arrows1;
    public MeshRenderer[] arrows2;
    public int direction;
    public Vector3 axis;
    private Vector3[] pastPositions;
    private Quaternion[] pastRotations;

    public cubeControl theCube;
    public int turnType;
    public bool indicator = false;
    public bool indicator1 = false;

    public Slider speed;
    public Button AutoSolveButton;
    public Button scramble;
    public Button solve;
    public Button back;

    // Start is called before the first frame update
    void Start()
    {
        children = new GameObject[35];
        pastPositions = new Vector3[35];
        pastRotations = new Quaternion[35];
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating == true)
        {
            //update rotateSpeed
            rotateSpeed = (speed.value * speed.value) / 1500;

            //roate thisSideObject by rotateSpeed and subtract difference from rotateDistance
            //thisSideObject.transform.RotateAround(new Vector3(0, 0, 0), axis, rotateSpeed * Time.deltaTime * direction);
            for (int i = 0; i < 35; i++)
            {
                if (children[i] != null)
                {
                    children[i].transform.RotateAround(new Vector3(0, 0, 0), axis, rotateSpeed * Time.deltaTime * direction);
                }
            }
            rotateDistance = rotateDistance - rotateSpeed * Time.deltaTime;

            if (rotateDistance < 0.0f)
            {
                for (int i = 0; i < 35; i++)
                {
                    if (children[i] != null)
                    {
                        children[i].transform.RotateAround(new Vector3(0, 0, 0), axis, rotateDistance * -1 * direction);
                    }
                }
                //re-enable every arrow
                for (int i = 0; i < 12; i++)
                {
                    arrows1[i].enabled = true;
                }
                //re-enable every arrow
                for (int i = 0; i < 12; i++)
                {
                    arrows2[i].enabled = true;
                }
                // set every object in children's position to pastPositions[i]
                for (int i = 0; i < 35; i++)
                {
                    if (children[i] != null)
                    {
                        children[i].transform.position = pastPositions[i];
                    }
                }
                // set every object in children's rotation to pastRotations[i]
                for (int i = 0; i < 35; i++)
                {
                    if (children[i] != null)
                    {
                        children[i].transform.rotation = pastRotations[i];
                    }
                }
                //unparent every object in thisSide.list from thisSideObject
                for (int i = 0; i < 35; i++)
                {
                    children[i] = null;
                }
                isRotating = false;

                //update the cube data structure and update the colors of the squares
                // 1 - top clockwise
                // 2 - top counter-clockwise
                // 3 - left clockwise
                // 4 - left counter-clockwise
                // 5 - right clockwise
                // 6 - right counter-clockwise
                // 7 - back clockwise
                // 8 - back counter-clockwise
                // 9 - front clockwise
                // 10 - front counter-clockwise 
                // 11 - bottom clockwise
                // 12 - bottom counter-clockwise
                theCube.sideRotation(turnType);
                theCube.updateColors();

                if (indicator == true)
                {
                    indicator = false;
                    if (indicator1 == true)
                    {
                        indicator1 = false;
                        AutoSolveButton.interactable = false;
                        //call autoDisplayNextMove
                        theCube.autoDisplayNextMove();
                    }
                    else
                    {
                        //call displayNextMove
                        theCube.displayNextMove();
                        AutoSolveButton.interactable = true;
                    }
                }
                else
                {
                    AutoSolveButton.interactable = true;
                }

                if (theCube.isSolving != true)
                {
                    scramble.interactable = true;
                    solve.interactable = true;
                }
            }
        }
    }

    public void spin()
    {
        //disable the back button
        back.interactable = false;

        //disable the auto-solve button
        AutoSolveButton.interactable = false;
        scramble.interactable = false;
        solve.interactable = false;

        if (isRotating == true)
        {
            return;
        }
        //disable every arrow's collider
        for (int i = 0; i < 12; i++)
        {
            arrows1[i].enabled = false;
        }
        //disable every arrow's renderer
        for (int i = 0; i < 12; i++)
        {
            arrows2[i].enabled = false;
        }
        //set every object in thisSide.list to be the child of thisSideObject
        for (int i = 0; i < 35; i++)
        {
            if (thisSide.list[i] != null)
            {
                children[i] = thisSide.list[i];
            }
        }
        for (int i = 0; i < 35; i++)
        {
            if (children[i] != null)
            {
                pastPositions[i] = children[i].transform.position;
            }
        }
        for (int i = 0; i < 35; i++)
        {
            if (children[i] != null)
            {
                pastRotations[i] = children[i].transform.rotation;
            }
        }
        //set the rotate distance to 90 and isRotating to true
        isRotating = true;
        rotateDistance = 90.0f;
    }
}
