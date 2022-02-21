using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrambleButtonPress : MonoBehaviour
{
    public cubeControl theCube;
    public Button thisButton;
    public Button scrambleButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void scrambleButtonPressFunction()
    {
        // call displayNextMove on theCube
        theCube.scramble();
        theCube.updateColors();
    }
}
