using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorPressed : MonoBehaviour
{
    public int intendedMode;
    public drag_and_flip_cube mover;

    public Button[] colors;
    public int yourself;
    public Color faded;
    public Color bright;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void colorPressedFunction()
    {
        //set the normal color of every button to 132, 132, 132, 165
        for (int i = 0; i < 7; i++)
        {
            ColorBlock cb = colors[i].colors;
            cb.normalColor = faded;
            cb.selectedColor = faded;
            colors[i].colors = cb;
        }

        //set your own normal color to 255, 255, 255, 255
        ColorBlock cb1 = colors[yourself].colors;
        cb1.normalColor = bright;
        cb1.selectedColor = bright;
        colors[yourself].colors = cb1;

        mover.mode = intendedMode;
    }
}
