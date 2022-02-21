using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class solveButtonPress : MonoBehaviour
{
    public cubeControl theCube;
    public Button thisButton;
    public Button scrambleButton;
    public Button autoSolve;
    public drag_and_flip_cube mover;

    public Button white;
    public Button blue;
    public Button orange;
    public Button red;
    public Button green;
    public Button yellow;
    public Button six;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void solveButtonPressFunction()
    {
        // call solve on theCube
        theCube.solveAdvanced();
        // disable this button
        thisButton.interactable = false;
        // disable the scramble button
        scrambleButton.interactable = false;
        // disable the autoSolve button
        autoSolve.interactable = false;
        // call displayNextMove on theCube
        theCube.displayNextMove();

        white.interactable = false;
        blue.interactable = false;
        orange.interactable = false;
        red.interactable = false;
        green.interactable = false;
        yellow.interactable = false;
        six.interactable = false;

        theCube.pastMode = mover.mode;

        //set the mode of drag_and_flip_cube to 6
        mover.mode = 6;
    }
}
