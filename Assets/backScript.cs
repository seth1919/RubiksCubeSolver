using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backScript : MonoBehaviour
{
    public cubeControl theCube;
    public GameObject[] arrows;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backButton()
    {
        if (theCube.nextMovesIndex != 1)
        {
            theCube.nextMovesIndex--;
            //update the cube data structure
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
            //perform the opposite of the last move
            if (theCube.nextMoves[theCube.nextMovesIndex] % 2 == 0)
            {
                //is even, do - 1
                //disable every arrow except the one whose spinScript.turnType == nextMoves[nextMovesIndex]
                for (int i = 0; i < 12; i++)
                {
                    if (((arrows[i]).GetComponent<spinScript>()).turnType == theCube.nextMoves[theCube.nextMovesIndex] - 1)
                    {
                        //enable the arrow
                        arrows[i].SetActive(true);
                        arrows[i].GetComponent<spinScript>().spin();
                        //set that arrow's calling indicator to indicate that it should call displayNextMove
                        ((arrows[i]).GetComponent<spinScript>()).indicator = true;
                        //set that arrow's calling indicator to indicate that it should call displayNextMove
                        ((arrows[i]).GetComponent<spinScript>()).indicator1 = true;
                    }
                    else
                    {
                        //disable the arrow
                        arrows[i].SetActive(false);
                    }
                }
            }
            else
            {
                //is odd, do + 1
                //disable every arrow except the one whose spinScript.turnType == nextMoves[nextMovesIndex]
                for (int i = 0; i < 12; i++)
                {
                    if (((arrows[i]).GetComponent<spinScript>()).turnType == theCube.nextMoves[theCube.nextMovesIndex] + 1)
                    {
                        //enable the arrow
                        arrows[i].SetActive(true);
                        arrows[i].GetComponent<spinScript>().spin();
                        //set that arrow's calling indicator to indicate that it should call displayNextMove
                        ((arrows[i]).GetComponent<spinScript>()).indicator = true;
                        //set that arrow's calling indicator to indicate that it should call displayNextMove
                        ((arrows[i]).GetComponent<spinScript>()).indicator1 = true;
                    }
                    else
                    {
                        //disable the arrow
                        arrows[i].SetActive(false);
                        arrows[i].GetComponent<spinScript>().isRotating = false;
                    }
                }
            }
            theCube.displayNextMove();
        }
    }
}
