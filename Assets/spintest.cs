using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spintest : MonoBehaviour
{

    public cubeControl theCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void superTest()
    {
        for (int i = 0; i < 10000; i++)
        {
            theCube.scramble();
            theCube.solveAdvanced();
        }
    }
}
