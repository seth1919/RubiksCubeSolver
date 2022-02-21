using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeControl : MonoBehaviour
{
    public class side
    {
        public int[] main;
        public int[] left;
        public int[] up;
        public int[] right;
        public int[] down;

        public int clockwise;
        public int counterClockwise;
        public int leftOfSide;
        public int upOfSide;
        public int rightOfSide;
        public int downOfSide;

        //public int[] mainObject;
        //public int[] leftObject;
        //public int[] upObject;
        //public int[] rightObject;
        //public int[] downObject;
        //public int[] blackHolders;

        public void createArrays()
        {
            main = new int[9];
            left = new int[3];
            up = new int[3];
            right = new int[3];
            down = new int[3];
            //mainObject = new int[9];
            //leftObject = new int[3];
            //upObject = new int[3];
            //rightObject = new int[3];
            //downObject = new int[3];
            //blackHolders = new int[9];
        }

        public void fillMain(int startingPosition)
        {
            for (int i = 0; i < 9; i++)
            {
                main[i] = i + startingPosition;
            }
        }
    }

    public class cube
    {
        public int[] colors = new int[54];
        public side top;
        public side left;
        public side right;
        public side front;
        public side back;
        public side bottom;

        public void createCube()
        {
            top = new side();
            left = new side();
            right = new side();
            front = new side();
            back = new side();
            bottom = new side();

            //create the 54 element array of colors, according to the reference cube
            // 0 = white
            // 1 = blue
            // 2 = orange
            // 3 = green
            // 4 = red
            // 5 = yellow
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int index = (i * 9) + j;
                    colors[index] = i;
                }
            }

            //create the arrays, starting with empty values
            top.createArrays();
            //fill main, according to the reference cube
            top.fillMain(0);
            //fill left, according to the reference cube
            top.left[0] = 38;
            top.left[1] = 37;
            top.left[2] = 36;
            //fill up, according to the reference cube
            top.up[0] = 29;
            top.up[1] = 28;
            top.up[2] = 27;
            //fill right, according to the reference cube
            top.right[0] = 20;
            top.right[1] = 19;
            top.right[2] = 18;
            //fill down, according to the reference cube
            top.down[0] = 11;
            top.down[1] = 10;
            top.down[2] = 9;
            //set other, according to the reference cube
            top.clockwise = 1;
            top.counterClockwise = 2;
            top.leftOfSide = 2;
            top.upOfSide = 4;
            top.rightOfSide = 3;
            top.downOfSide = 5;

            left.createArrays();
            //fill main, according to the reference cube
            left.fillMain(36);
            //fill left, according to the reference cube
            left.left[0] = 35;
            left.left[1] = 32;
            left.left[2] = 29;
            //fill up, according to the reference cube
            left.up[0] = 0;
            left.up[1] = 3;
            left.up[2] = 6;
            //fill right, according to the reference cube
            left.right[0] = 9;
            left.right[1] = 12;
            left.right[2] = 15;
            //fill down, according to the reference cube
            left.down[0] = 45;
            left.down[1] = 48;
            left.down[2] = 51;
            //set other, according to the reference cube
            left.clockwise = 3;
            left.counterClockwise = 4;
            left.leftOfSide = 4;
            left.rightOfSide = 5;
            left.upOfSide = 1;
            left.downOfSide = 6;

            right.createArrays();
            //fill main, according to the reference cube
            right.fillMain(18);
            //fill left, according to the reference cube
            right.left[0] = 17;
            right.left[1] = 14;
            right.left[2] = 11;
            //fill up, according to the reference cube
            right.up[0] = 8;
            right.up[1] = 5;
            right.up[2] = 2;
            //fill right, according to the reference cube
            right.right[0] = 27;
            right.right[1] = 30;
            right.right[2] = 33;
            //fill down, according to the reference cube
            right.down[0] = 53;
            right.down[1] = 50;
            right.down[2] = 47;
            //set other, according to the reference cube
            right.clockwise = 5;
            right.counterClockwise = 6;
            right.leftOfSide = 5;
            right.rightOfSide = 4;
            right.upOfSide = 1;
            right.downOfSide = 6;

            front.createArrays();
            //fill main, according to the reference cube
            front.fillMain(9);
            //fill left, according to the reference cube
            front.left[0] = 44;
            front.left[1] = 41;
            front.left[2] = 38;
            //fill up, according to the reference cube
            front.up[0] = 6;
            front.up[1] = 7;
            front.up[2] = 8;
            //fill right, according to the reference cube
            front.right[0] = 18;
            front.right[1] = 21;
            front.right[2] = 24;
            //fill down, according to the reference cube
            front.down[0] = 47;
            front.down[1] = 46;
            front.down[2] = 45;
            //set other, according to the reference cube
            front.clockwise = 9;
            front.counterClockwise = 10;
            front.leftOfSide = 2;
            front.rightOfSide = 3;
            front.upOfSide = 1;
            front.downOfSide = 6;

            back.createArrays();
            //fill main, according to the reference cube
            back.fillMain(27);
            //fill left, according to the reference cube
            back.left[0] = 26;
            back.left[1] = 23;
            back.left[2] = 20;
            //fill up, according to the reference cube
            back.up[0] = 2;
            back.up[1] = 1;
            back.up[2] = 0;
            //fill right, according to the reference cube
            back.right[0] = 36;
            back.right[1] = 39;
            back.right[2] = 42;
            //fill down, according to the reference cube
            back.down[0] = 51;
            back.down[1] = 52;
            back.down[2] = 53;
            //set other, according to the reference cube
            back.clockwise = 7;
            back.counterClockwise = 8;
            back.leftOfSide = 3;
            back.rightOfSide = 2;
            back.upOfSide = 1;
            back.downOfSide = 6;

            bottom.createArrays();
            //fill main, according to the reference cube
            bottom.fillMain(45);
            //fill left, according to the reference cube
            bottom.left[0] = 42;
            bottom.left[1] = 43;
            bottom.left[2] = 44;
            //fill up, according to the reference cube
            bottom.up[0] = 15;
            bottom.up[1] = 16;
            bottom.up[2] = 17;
            //fill right, according to the reference cube
            bottom.right[0] = 24;
            bottom.right[1] = 25;
            bottom.right[2] = 26;
            //fill down, according to the reference cube
            bottom.down[0] = 33;
            bottom.down[1] = 34;
            bottom.down[2] = 35;
            //set other, according to the reference cube
            bottom.clockwise = 11;
            bottom.counterClockwise = 12;
            bottom.leftOfSide = 2;
            bottom.rightOfSide = 3;
            bottom.upOfSide = 5;
            bottom.downOfSide = 4;
        }
    }

    public cube theCube = new cube();
    public GameObject[] squares;
    public GameObject test;
    public GameObject[] arrows;
    side[] sideIndexes;
    public int[] nextMoves;
    public int nextMovesIndex = 0;
    public bool isSolving = false;
    public Button back;
    public Button theButton;
    public Button scrambleButton;
    public Button autoSolve;
    public Button white;
    public Button blue;
    public Button orange;
    public Button red;
    public Button green;
    public Button yellow;
    public Button six;
    public int pastMode;
    public drag_and_flip_cube mover;

    public int movesTotal;
    public InputField movesInputField;

    // Start is called before the first frame update
    void Start()
    {
        theCube.createCube();
        sideIndexes = new side[7];
        sideIndexes[1] = theCube.top;
        sideIndexes[2] = theCube.left;
        sideIndexes[3] = theCube.right;
        sideIndexes[4] = theCube.back;
        sideIndexes[5] = theCube.front;
        sideIndexes[6] = theCube.bottom;

        nextMoves = new int[1000];
        //arrows = new GameObject[12];
    }

    // Update is called once per frame
    void Update()
    {

    }

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
    public void sideRotation(int side)
    {

        int sideIndex = ((side + 1) / 2);

        // sideIndexes[sideIndex] is the relevant side
        if (side % 2 == 0)
        {
            //rotate counter-clockwise

            //roate main
            //copy the array for reference
            int[] reference = new int[9];
            sideIndexes[sideIndex].main.CopyTo(reference, 0);
            int[] originalColors = new int[9];
            //copy sideIndexes[sideIndex].main[] to originalColors[]
            for (int i = 0; i < 9; i++)
            {
                originalColors[i] = theCube.colors[sideIndexes[sideIndex].main[i]];
            }
            //loop through each row of the reference, copy it into the last column of sideIndexes[sideIndex].main
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    //sideIndexes[sideIndex].main[TwoDtoOneD(y, 2 - x)] = reference[TwoDtoOneD(x, y)];
                    theCube.colors[sideIndexes[sideIndex].main[TwoDtoOneD(y, 2 - x)]] = originalColors[TwoDtoOneD(x, y)];
                }
            }
            int[] temp = new int[3];
            int[] temp1 = new int[3];
            //move left to down
                //copy down to a new array
                for (int i = 0; i < 3; i++)
                {
                    temp[i] = theCube.colors[sideIndexes[sideIndex].down[i]];
                }
                //sideIndexes[sideIndex].down.CopyTo(temp, 0);
                //copy left to down
                for (int i = 0; i < 3; i++)
                {
                    theCube.colors[sideIndexes[sideIndex].down[i]] = theCube.colors[sideIndexes[sideIndex].left[i]];
                }
                //sideIndexes[sideIndex].left.CopyTo(sideIndexes[sideIndex].down, 0);
            //move down to right
                //copy right to a new array
                for (int i = 0; i < 3; i++)
                {
                    temp1[i] = theCube.colors[sideIndexes[sideIndex].right[i]];
                }
                //sideIndexes[sideIndex].right.CopyTo(temp1, 0);
                //copy temp to right
                for (int i = 0; i < 3; i++)
                {
                    theCube.colors[sideIndexes[sideIndex].right[i]] = temp[i];
                }
                //temp.CopyTo(sideIndexes[sideIndex].right, 0);
            //move right to up
                //copy up to temp
                for (int i = 0; i < 3; i++)
                {
                    temp[i] = theCube.colors[sideIndexes[sideIndex].up[i]];
                }
                //sideIndexes[sideIndex].up.CopyTo(temp, 0);
                //copy temp1 to up
                for (int i = 0; i < 3; i++)
                {
                    theCube.colors[sideIndexes[sideIndex].up[i]] = temp1[i];
                }
                //temp1.CopyTo(sideIndexes[sideIndex].up, 0);
            //move up to left
                //copy temp to left
                for (int i = 0; i < 3; i++)
                {
                    theCube.colors[sideIndexes[sideIndex].left[i]] = temp[i];
                }
                //temp.CopyTo(sideIndexes[sideIndex].left, 0);
        }
        else
        {
            //rotate clockwise

            /*
            //rotate main
            //copy the array for reference
            int[] reference = new int[9];
            sideIndexes[sideIndex].main.CopyTo(reference, 0);
            //loop through each row of the reference, copy it into the last column of sideIndexes[sideIndex].main
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    sideIndexes[sideIndex].main[TwoDtoOneD(2 - y, x)] = reference[TwoDtoOneD(x, y)];
                }
            }
            */

            //roate main
            //copy the array for reference
            int[] reference = new int[9];
            sideIndexes[sideIndex].main.CopyTo(reference, 0);
            int[] originalColors = new int[9];
            //copy sideIndexes[sideIndex].main[] to originalColors[]
            for (int i = 0; i < 9; i++)
            {
                originalColors[i] = theCube.colors[sideIndexes[sideIndex].main[i]];
            }
            //loop through each row of the reference, copy it into the last column of sideIndexes[sideIndex].main
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    //sideIndexes[sideIndex].main[TwoDtoOneD(y, 2 - x)] = reference[TwoDtoOneD(x, y)];
                    theCube.colors[sideIndexes[sideIndex].main[TwoDtoOneD(2 - y, x)]] = originalColors[TwoDtoOneD(x, y)];
                }
            }

            int[] temp = new int[3];
            int[] temp1 = new int[3];
            //move left to top
                //copy top to a new array
                for (int i = 0; i < 3; i++)
                {
                    temp[i] = theCube.colors[sideIndexes[sideIndex].up[i]];
                }
                //sideIndexes[sideIndex].up.CopyTo(temp, 0);
                //copy left to top
                for (int i = 0; i < 3; i++)
                {
                    theCube.colors[sideIndexes[sideIndex].up[i]] = theCube.colors[sideIndexes[sideIndex].left[i]];
                }
                //sideIndexes[sideIndex].left.CopyTo(sideIndexes[sideIndex].up, 0);
            //move top to right
                //copy right to a new array
                for (int i = 0; i < 3; i++)
                {
                    temp1[i] = theCube.colors[sideIndexes[sideIndex].right[i]];
                }
                //sideIndexes[sideIndex].right.CopyTo(temp1, 0);
                //copy temp to right
                for (int i = 0; i < 3; i++)
                {
                    theCube.colors[sideIndexes[sideIndex].right[i]] = temp[i];
                }
                //temp.CopyTo(sideIndexes[sideIndex].right, 0);
            //move right to bottom
                //copy bottom to temp
                for (int i = 0; i < 3; i++)
                {
                    temp[i] = theCube.colors[sideIndexes[sideIndex].down[i]];
                }
                //sideIndexes[sideIndex].down.CopyTo(temp, 0);
                //copy temp1 to bottom
                for (int i = 0; i < 3; i++)
                {
                    theCube.colors[sideIndexes[sideIndex].down[i]] = temp1[i];
                }
                //temp1.CopyTo(sideIndexes[sideIndex].down, 0);
            //move bottom to left
                //copy temp to left
                for (int i = 0; i < 3; i++)
                {
                    theCube.colors[sideIndexes[sideIndex].left[i]] = temp[i];
                }
                //temp.CopyTo(sideIndexes[sideIndex].left, 0);
        }
    }

    public void updateColors()
    {
        //loop through the cube's colors list and set the colors of squares[i] accordingly
        for (int i = 0; i < 54; i++)
        {
            switch (theCube.colors[i])
            {
                // 0 = white
                // 1 = blue
                // 2 = orange
                // 3 = green
                // 4 = red
                // 5 = yellow
                case 0:
                    //set squares[i] to white
                    squares[i].GetComponent<Renderer>().material.color = new Color(231f / 255f, 231f / 255f, 231f / 255f);
                    break;
                case 1:
                    //set squares[i] to blue
                    squares[i].GetComponent<Renderer>().material.color = new Color(0f / 255f, 9f / 255f, 255f / 255f);
                    break;
                case 2:
                    //set squares[i] to orange
                    squares[i].GetComponent<Renderer>().material.color = new Color(231f / 255f, 107f / 255f, 0f / 255f);
                    break;
                case 3:
                    //set squares[i] to green
                    squares[i].GetComponent<Renderer>().material.color = new Color(3f / 255f, 103f / 255f, 0f / 255f);
                    break;
                case 4:
                    //set squares[i] to red
                    squares[i].GetComponent<Renderer>().material.color = new Color(199f / 255f, 0f / 255f, 10f / 255f);
                    break;
                case 5:
                    //set squares[i] to yellow
                    squares[i].GetComponent<Renderer>().material.color = new Color(231f / 255f, 227f / 255f, 0f / 255f);
                    break;
                default:
                    Debug.Log("no color");
                    break;
            }
        }
    }

    int TwoDtoOneD(int x, int y)
    {
        return ((y * 3) + x);
    }

    public void solveAdvanced()
    {
        int nextMovesBuilderIndex = 0;
        /*
         *      add a new move to nextMoves with:
         *      nextMoves[nextMovesBuilderIndex] = <the move integer>;
         *      nextMovesBuilderIndex++;
         */

        //save the state of the cube
        int[] colorsCopy = new int[theCube.colors.Length];
        theCube.colors.CopyTo(colorsCopy, 0);

        // 0 = white
        // 1 = blue
        // 2 = orange
        // 3 = green
        // 4 = red
        // 5 = yellow
        int[] whiteOtherColors = { theCube.colors[theCube.front.main[4]], theCube.colors[theCube.left.main[4]], theCube.colors[theCube.back.main[4]], theCube.colors[theCube.right.main[4]] }; //whiteOtherColors[j]
        int[] sideSearch = { 5, 2, 4, 3 }; //sideIndexes[sideSearch[j]] 
        //for every white-other square on the cube
        for (int j = 0; j < 4; j++)
        {
            //search through the sides (sideIndexes[2-5]) for the side that contains the white-blue square.
            int sideOfInterest = 0;
            for (int i = 2; i < 6; i++)
            {
                int[] results = { theCube.colors[sideIndexes[i].up[1]], theCube.colors[sideIndexes[i].left[1]], theCube.colors[sideIndexes[i].right[1]], theCube.colors[sideIndexes[i].down[1]] };
                int resultsIndex = 0;
                for (int boo = 1; boo < 8; boo = boo + 2)
                {
                    //for main[1] and up[1]
                    if (theCube.colors[sideIndexes[i].main[boo]] == whiteOtherColors[j] || results[resultsIndex] == whiteOtherColors[j])
                    {
                        if (theCube.colors[sideIndexes[i].main[boo]] == theCube.colors[theCube.top.main[4]] || results[resultsIndex] == theCube.colors[theCube.top.main[4]])
                        {
                            //save the index of this side (i)
                            sideOfInterest = i;
                            boo = 8;
                            i = 6;
                        }
                    }
                    resultsIndex++;
                }
            }
            if (sideOfInterest == 0 || sideOfInterest == 6)
            {
                Debug.Log("Problem!!");
            }

            //rotate that side until the white-blue square is on the bottom
            int numberOfRotations = 0;
            while (!((theCube.colors[sideIndexes[sideOfInterest].main[7]] == whiteOtherColors[j] || theCube.colors[sideIndexes[sideOfInterest].down[1]] == whiteOtherColors[j]) && (theCube.colors[sideIndexes[sideOfInterest].main[7]] == theCube.colors[theCube.top.main[4]] || theCube.colors[sideIndexes[sideOfInterest].down[1]] == theCube.colors[theCube.top.main[4]])))
            {
                //update the test cube
                sideRotation(sideIndexes[sideOfInterest].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideOfInterest].clockwise;
                nextMovesBuilderIndex++;
                numberOfRotations++;
            }

            //rotate the bottom once
            //update the test cube
            sideRotation(11);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = 11;
            nextMovesBuilderIndex++;

            //rotate the first side the opposite direction it was previously rotated (or 4 - 2 times in the same direction)
            for (int i = 0; i < numberOfRotations; i++)
            {
                //update the test cube
                sideRotation(sideIndexes[sideOfInterest].counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideOfInterest].counterClockwise;
                nextMovesBuilderIndex++;
            }

            //rotate the bottom until the white-blue square is on the blue side
            while (!((theCube.colors[sideIndexes[sideSearch[j]].main[7]] == whiteOtherColors[j] || theCube.colors[sideIndexes[sideSearch[j]].down[1]] == whiteOtherColors[j]) && (theCube.colors[sideIndexes[sideSearch[j]].main[7]] == theCube.colors[theCube.top.main[4]] || theCube.colors[sideIndexes[sideSearch[j]].down[1]] == theCube.colors[theCube.top.main[4]])))
            {
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;
            }

            //if white side of white-blue square is on bottom, rotate the blue side until white-blue is on the top
            if (theCube.colors[sideIndexes[sideSearch[j]].main[7]] == whiteOtherColors[j])
            {
                //update the test cube
                sideRotation(sideIndexes[sideSearch[j]].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearch[j]].clockwise;
                nextMovesBuilderIndex++;
                //update the test cube
                sideRotation(sideIndexes[sideSearch[j]].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearch[j]].clockwise;
                nextMovesBuilderIndex++;
            }
            else
            {
                // otherwise, do the algorithm

                // bottom counter-clockwise
                //update the test cube
                sideRotation(theCube.bottom.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                nextMovesBuilderIndex++;

                // left-of-side counter-clockwise
                //update the test cube
                sideRotation(sideIndexes[sideIndexes[sideSearch[j]].leftOfSide].counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideSearch[j]].leftOfSide].counterClockwise;
                nextMovesBuilderIndex++;

                // side clockwise
                //update the test cube
                sideRotation(sideIndexes[sideSearch[j]].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearch[j]].clockwise;
                nextMovesBuilderIndex++;

                // left-of-side clockwise
                //update the test cube
                sideRotation(sideIndexes[sideIndexes[sideSearch[j]].leftOfSide].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideSearch[j]].leftOfSide].clockwise;
                nextMovesBuilderIndex++;
            }
        }

        {
            int[] firstColors = { theCube.colors[theCube.top.main[4]], theCube.colors[theCube.top.main[4]], theCube.colors[theCube.top.main[4]], theCube.colors[theCube.top.main[4]] }; //firstColors[j] for the first color on the square we are looking for
            int[] secondColors = { theCube.colors[sideIndexes[2].main[4]], theCube.colors[sideIndexes[4].main[4]], theCube.colors[sideIndexes[3].main[4]], theCube.colors[sideIndexes[5].main[4]] }; //secondColors[j] for the seond color on the square we are looking for
            int[] thirdColors = { theCube.colors[sideIndexes[5].main[4]], theCube.colors[sideIndexes[2].main[4]], theCube.colors[sideIndexes[4].main[4]], theCube.colors[sideIndexes[3].main[4]] }; //thirdColors[j] for the third color on the square we are looking for
            int[] sideSearchOrder = { 2, 4, 3, 5 }; //sideIndexes[sideSearchOrder[j]] for the side we want the square to be rotated to
            //for every white-other-other square on the cube
            for (int j = 0; j < 4; j++)
            {
                //search through the sides (sideIndexes[2-5]) for the side that contains the white-other-other square in the top
                bool leftRemember = false;
                int sideOfInterest = 0;
                for (int i = 2; i < 6; i++)
                {
                    //search through the two squares on the side we want to analyze.
                    if (theCube.colors[sideIndexes[i].main[0]] == firstColors[j] || theCube.colors[sideIndexes[i].left[2]] == firstColors[j] || theCube.colors[sideIndexes[i].up[0]] == firstColors[j])
                    {
                        if (theCube.colors[sideIndexes[i].main[0]] == secondColors[j] || theCube.colors[sideIndexes[i].left[2]] == secondColors[j] || theCube.colors[sideIndexes[i].up[0]] == secondColors[j])
                        {
                            if (theCube.colors[sideIndexes[i].main[0]] == thirdColors[j] || theCube.colors[sideIndexes[i].left[2]] == thirdColors[j] || theCube.colors[sideIndexes[i].up[0]] == thirdColors[j])
                            {
                                leftRemember = true;
                                sideOfInterest = i;
                                break;
                            }
                        }
                    }
                    if (theCube.colors[sideIndexes[i].main[2]] == firstColors[j] || theCube.colors[sideIndexes[i].right[0]] == firstColors[j] || theCube.colors[sideIndexes[i].up[2]] == firstColors[j])
                    {
                        if (theCube.colors[sideIndexes[i].main[2]] == secondColors[j] || theCube.colors[sideIndexes[i].right[0]] == secondColors[j] || theCube.colors[sideIndexes[i].up[2]] == secondColors[j])
                        {
                            if (theCube.colors[sideIndexes[i].main[2]] == thirdColors[j] || theCube.colors[sideIndexes[i].right[0]] == thirdColors[j] || theCube.colors[sideIndexes[i].up[2]] == thirdColors[j])
                            {
                                sideOfInterest = i;
                                break;
                            }
                        }
                    }
                }

                //if the a side with the white-other-other square on top is found (sideOfInterest != 0)
                if (sideOfInterest != 0)
                {
                    //if the side of interest has the white-other-other square on the left, do the left-to-bottom algorithm
                    if (leftRemember == true)
                    {
                        //side-of-interest counter-clockwise
                        //update the test cube
                        sideRotation(sideIndexes[sideOfInterest].counterClockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = sideIndexes[sideOfInterest].counterClockwise;
                        nextMovesBuilderIndex++;

                        //bottom counter-clockwise
                        //update the test cube
                        sideRotation(theCube.bottom.counterClockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                        nextMovesBuilderIndex++;

                        //side-of-interest clockwise
                        //update the test cube
                        sideRotation(sideIndexes[sideOfInterest].clockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = sideIndexes[sideOfInterest].clockwise;
                        nextMovesBuilderIndex++;
                    }
                    else
                    {
                        //if otherwise, do right-to-bottom algorithm
                        //side-of-interest clockwise
                        //update the test cube
                        sideRotation(sideIndexes[sideOfInterest].clockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = sideIndexes[sideOfInterest].clockwise;
                        nextMovesBuilderIndex++;

                        //bottom clockwise
                        //update the test cube
                        sideRotation(theCube.bottom.clockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                        nextMovesBuilderIndex++;

                        //side-of-interest counter-clockwise
                        //update the test cube
                        sideRotation(sideIndexes[sideOfInterest].counterClockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = sideIndexes[sideOfInterest].counterClockwise;
                        nextMovesBuilderIndex++;
                    }
                }


                //rotate bottom until the white-other-other square is below the desired position of the right side of the first color
                bool shouldRepeat = true;
                while (true)
                {
                    if (theCube.colors[sideIndexes[sideSearchOrder[j]].main[8]] == firstColors[j] || theCube.colors[sideIndexes[sideSearchOrder[j]].right[2]] == firstColors[j] || theCube.colors[sideIndexes[sideSearchOrder[j]].down[0]] == firstColors[j])
                    {
                        if (theCube.colors[sideIndexes[sideSearchOrder[j]].main[8]] == secondColors[j] || theCube.colors[sideIndexes[sideSearchOrder[j]].right[2]] == secondColors[j] || theCube.colors[sideIndexes[sideSearchOrder[j]].down[0]] == secondColors[j])
                        {
                            if (theCube.colors[sideIndexes[sideSearchOrder[j]].main[8]] == thirdColors[j] || theCube.colors[sideIndexes[sideSearchOrder[j]].right[2]] == thirdColors[j] || theCube.colors[sideIndexes[sideSearchOrder[j]].down[0]] == thirdColors[j])
                            {
                                shouldRepeat = false;
                            }
                        }
                    }
                    if (shouldRepeat == true)
                    {
                        //rotate the bottom
                        //update the test cube
                        sideRotation(theCube.bottom.clockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                        nextMovesBuilderIndex++;
                    }
                    else
                    {
                        //break the loop
                        break;
                    }
                }

                //color-side clockwise
                //update the test cube
                sideRotation(sideIndexes[sideSearchOrder[j]].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearchOrder[j]].clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                while (true)
                {
                    //(1) if color-side.right[2] is white (square is oriented correctly), color-side counter-clockwise and you're done
                    if (theCube.colors[sideIndexes[sideSearchOrder[j]].right[2]] == theCube.colors[theCube.top.main[4]])
                    {
                        //update the test cube
                        sideRotation(sideIndexes[sideSearchOrder[j]].counterClockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearchOrder[j]].counterClockwise;
                        nextMovesBuilderIndex++;

                        break;
                    }
                    else
                    {
                        //(2) otherwise, repeat bottom clockwise, color-side counter-clockwise, bottom counter-clockwise, color-side clockwise, bottom clockwise
                        //bottom clockwise
                        sideRotation(theCube.bottom.clockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                        nextMovesBuilderIndex++;

                        //color-side counter-clockwise
                        sideRotation(sideIndexes[sideSearchOrder[j]].counterClockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearchOrder[j]].counterClockwise;
                        nextMovesBuilderIndex++;

                        //bottom counter-clockwise
                        sideRotation(theCube.bottom.counterClockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                        nextMovesBuilderIndex++;

                        //color-side clockwise
                        sideRotation(sideIndexes[sideSearchOrder[j]].clockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearchOrder[j]].clockwise;
                        nextMovesBuilderIndex++;

                        //bottom clockwise
                        sideRotation(theCube.bottom.clockwise);
                        //add the rotation to nextMoves
                        nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                        nextMovesBuilderIndex++;
                    }
                }
            }
        }

        int[] firstColors1 = { theCube.colors[sideIndexes[5].main[4]], theCube.colors[sideIndexes[2].main[4]], theCube.colors[sideIndexes[4].main[4]], theCube.colors[sideIndexes[3].main[4]] }; //firstColors1[j]
        int[] secondColors1 = { theCube.colors[sideIndexes[3].main[4]], theCube.colors[sideIndexes[5].main[4]], theCube.colors[sideIndexes[2].main[4]], theCube.colors[sideIndexes[4].main[4]] }; //secondColors1[j]
        int[] sideSearchOrder1 = { 3, 5, 2, 4 }; //sideIndexes[sideSearchOrder1[j]] for the side we want the square to be rotated to
        //for every sideColor-sideColor square on the cube
        for (int j = 0; j < 4; j++)
        {
            //search through the sides (sideIndexes[2-5]) for the side that contains the sideColor-sideColor square to the right
            int sideOfInterest = 0;
            for (int i = 2; i < 6; i++)
            {
                if (theCube.colors[sideIndexes[i].main[3]] == firstColors1[j] || theCube.colors[sideIndexes[i].left[1]] == firstColors1[j])
                {
                    if (theCube.colors[sideIndexes[i].main[3]] == secondColors1[j] || theCube.colors[sideIndexes[i].left[1]] == secondColors1[j])
                    {
                        sideOfInterest = i;
                        break;
                    }
                }
            }

            //if such a side exists (sideOfInterest != 0), do the right algorithm to move the piece to the top
            if (sideOfInterest != 0)
            {
                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //leftOfSide clockwise:  sideIndexes[sideIndexes[i].rightOfSide].clockwise
                sideRotation(sideIndexes[sideIndexes[sideOfInterest].leftOfSide].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideOfInterest].leftOfSide].clockwise;
                nextMovesBuilderIndex++;

                //bottom counterClockwise
                sideRotation(theCube.bottom.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                nextMovesBuilderIndex++;

                //leftOfSide counterClockwise
                sideRotation(sideIndexes[sideIndexes[sideOfInterest].leftOfSide].counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideOfInterest].leftOfSide].counterClockwise;
                nextMovesBuilderIndex++;

                //bottom counterClockwise
                sideRotation(theCube.bottom.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                nextMovesBuilderIndex++;

                //side-of-interest counterClockwise
                sideRotation(sideIndexes[sideOfInterest].counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideOfInterest].counterClockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //side-of-interest clockwise
                sideRotation(sideIndexes[sideOfInterest].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideOfInterest].clockwise;
                nextMovesBuilderIndex++;
            }

            //rotate the top until the sideColor-sideColor square is above it's correct color
            while (!((theCube.colors[sideIndexes[sideSearchOrder1[j]].main[7]] == firstColors1[j] || theCube.colors[sideIndexes[sideSearchOrder1[j]].down[1]] == firstColors1[j]) && (theCube.colors[sideIndexes[sideSearchOrder1[j]].main[7]] == secondColors1[j] || theCube.colors[sideIndexes[sideSearchOrder1[j]].down[1]] == secondColors1[j])))
            {
                if (nextMovesBuilderIndex == 900)
                {
                    Debug.Log("problem");
                }

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;
            }

            //bottom clockwise
            //update the test cube
            sideRotation(theCube.bottom.clockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
            nextMovesBuilderIndex++;

            //leftOfSide clockwise:  sideIndexes[sideIndexes[i].rightOfSide].clockwise
            sideRotation(sideIndexes[sideIndexes[sideSearchOrder1[j]].leftOfSide].clockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideSearchOrder1[j]].leftOfSide].clockwise;
            nextMovesBuilderIndex++;

            //bottom counterClockwise
            sideRotation(theCube.bottom.counterClockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
            nextMovesBuilderIndex++;

            //leftOfSide counterClockwise
            sideRotation(sideIndexes[sideIndexes[sideSearchOrder1[j]].leftOfSide].counterClockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideSearchOrder1[j]].leftOfSide].counterClockwise;
            nextMovesBuilderIndex++;

            //bottom counterClockwise
            sideRotation(theCube.bottom.counterClockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
            nextMovesBuilderIndex++;

            //side-of-interest counterClockwise
            sideRotation(sideIndexes[sideSearchOrder1[j]].counterClockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearchOrder1[j]].counterClockwise;
            nextMovesBuilderIndex++;

            //bottom clockwise
            sideRotation(theCube.bottom.clockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
            nextMovesBuilderIndex++;

            //side-of-interest clockwise
            sideRotation(sideIndexes[sideSearchOrder1[j]].clockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearchOrder1[j]].clockwise;
            nextMovesBuilderIndex++;

            //if the orientation is wrong, use the right algorithm
            if (theCube.colors[sideIndexes[sideSearchOrder1[j]].main[3]] != secondColors1[j])
            {
                //use right algorithm, turn top twice, use right algorithm

                //use the right algorithm
                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //leftOfSide clockwise:  sideIndexes[sideIndexes[i].rightOfSide].clockwise
                sideRotation(sideIndexes[sideIndexes[sideSearchOrder1[j]].leftOfSide].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideSearchOrder1[j]].leftOfSide].clockwise;
                nextMovesBuilderIndex++;

                //bottom counterClockwise
                sideRotation(theCube.bottom.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                nextMovesBuilderIndex++;

                //leftOfSide counterClockwise
                sideRotation(sideIndexes[sideIndexes[sideSearchOrder1[j]].leftOfSide].counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideSearchOrder1[j]].leftOfSide].counterClockwise;
                nextMovesBuilderIndex++;

                //bottom counterClockwise
                sideRotation(theCube.bottom.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                nextMovesBuilderIndex++;

                //side-of-interest counterClockwise
                sideRotation(sideIndexes[sideSearchOrder1[j]].counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearchOrder1[j]].counterClockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //side-of-interest clockwise
                sideRotation(sideIndexes[sideSearchOrder1[j]].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearchOrder1[j]].clockwise;
                nextMovesBuilderIndex++;

                //TURN TOP TWICE
                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;
                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;


                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //leftOfSide clockwise:  sideIndexes[sideIndexes[i].rightOfSide].clockwise
                sideRotation(sideIndexes[sideIndexes[sideSearchOrder1[j]].leftOfSide].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideSearchOrder1[j]].leftOfSide].clockwise;
                nextMovesBuilderIndex++;

                //bottom counterClockwise
                sideRotation(theCube.bottom.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                nextMovesBuilderIndex++;

                //leftOfSide counterClockwise
                sideRotation(sideIndexes[sideIndexes[sideSearchOrder1[j]].leftOfSide].counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideSearchOrder1[j]].leftOfSide].counterClockwise;
                nextMovesBuilderIndex++;

                //bottom counterClockwise
                sideRotation(theCube.bottom.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                nextMovesBuilderIndex++;

                //side-of-interest counterClockwise
                sideRotation(sideIndexes[sideSearchOrder1[j]].counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearchOrder1[j]].counterClockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //side-of-interest clockwise
                sideRotation(sideIndexes[sideSearchOrder1[j]].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideSearchOrder1[j]].clockwise;
                nextMovesBuilderIndex++;
            }
        }

        int[,] yellowPosition1 = new int[4, 9]{
        {
                                                0, 1, 0,
                                                1, 2, 1,
                                                0, 1, 0
        },
        {
                                                0, 2, 0,
                                                2, 2, 1,
                                                0, 1, 0
        },
        {
                                                0, 1, 0,
                                                2, 2, 2,
                                                0, 1, 0
        },
        {
                                                0, 2, 0,
                                                2, 2, 2,
                                                0, 2, 0
        }
        };
        //0: doesn't matter
        //1: must be not yellow
        //2: must be yellow
        //rotate the bottom until it matches one of the images
        int correctImage = -1;
        while (true)
        {
            //check the bottom against each image
            bool willPass = true;
            for (int i = 0; i < 4; i++)
            {
                willPass = true;
                for (int j = 0; j < 9; j++)
                {
                    //if the condition described by the number is not met, the bottom does not match this image
                    switch (yellowPosition1[i, j])
                    {
                        case 0:

                            break;
                        case 1:
                            if (theCube.colors[theCube.bottom.main[j]] == theCube.colors[theCube.bottom.main[4]])
                            {
                                willPass = false;
                            }
                            break;
                        case 2:
                            if (theCube.colors[theCube.bottom.main[j]] != theCube.colors[theCube.bottom.main[4]])
                            {
                                willPass = false;
                            }
                            break;
                    }
                }
                if (willPass == true)
                {
                    correctImage = i;
                    break;
                }
            }
            if (willPass == true)
            {
                break;
            }

            //rotate the bottom
            //bottom clockwise
            //update the test cube
            sideRotation(theCube.bottom.clockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
            nextMovesBuilderIndex++;
        }
        if (correctImage != 0)
        {
            for (int i = 0; i < 3 - correctImage; i++)
            {
                //do the yellow cross algorithm
                //back clockwise
                //update the test cube
                sideRotation(theCube.back.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.back.clockwise;
                nextMovesBuilderIndex++;

                //right clockwise
                //update the test cube
                sideRotation(theCube.right.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //right counterClockwise
                //update the test cube
                sideRotation(theCube.right.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.counterClockwise;
                nextMovesBuilderIndex++;

                //bottom counterClockwise
                //update the test cube
                sideRotation(theCube.bottom.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                nextMovesBuilderIndex++;

                //back counterClockwise
                //update the test cube
                sideRotation(theCube.back.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.back.counterClockwise;
                nextMovesBuilderIndex++;
            }
        }
        else
        {
            //do the algorithm once, rotate until matches yellowPosition1[1], do algorithm twice
            {
                //do the yellow cross algorithm
                //back clockwise
                //update the test cube
                sideRotation(theCube.back.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.back.clockwise;
                nextMovesBuilderIndex++;

                //right clockwise
                //update the test cube
                sideRotation(theCube.right.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //right counterClockwise
                //update the test cube
                sideRotation(theCube.right.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.counterClockwise;
                nextMovesBuilderIndex++;

                //bottom counterClockwise
                //update the test cube
                sideRotation(theCube.bottom.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                nextMovesBuilderIndex++;

                //back counterClockwise
                //update the test cube
                sideRotation(theCube.back.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.back.counterClockwise;
                nextMovesBuilderIndex++;
            }
            while (true)
            {
                //check the bottom against each image
                bool willPass = true;
                for (int i = 0; i < 4; i++)
                {
                    willPass = true;
                    for (int j = 0; j < 9; j++)
                    {
                        //if the condition described by the number is not met, the bottom does not match this image
                        switch (yellowPosition1[i, j])
                        {
                            case 0:

                                break;
                            case 1:
                                if (theCube.colors[theCube.bottom.main[j]] == theCube.colors[theCube.bottom.main[4]])
                                {
                                    willPass = false;
                                }
                                break;
                            case 2:
                                if (theCube.colors[theCube.bottom.main[j]] != theCube.colors[theCube.bottom.main[4]])
                                {
                                    willPass = false;
                                }
                                break;
                        }
                    }
                    if (willPass == true)
                    {
                        correctImage = i;
                        break;
                    }
                }
                if (willPass == true)
                {
                    break;
                }

                //rotate the bottom
                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;
            }
            for (int i = 0; i < 3 - correctImage; i++)
            {
                //do the yellow cross algorithm
                //back clockwise
                //update the test cube
                sideRotation(theCube.back.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.back.clockwise;
                nextMovesBuilderIndex++;

                //right clockwise
                //update the test cube
                sideRotation(theCube.right.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //right counterClockwise
                //update the test cube
                sideRotation(theCube.right.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.counterClockwise;
                nextMovesBuilderIndex++;

                //bottom counterClockwise
                //update the test cube
                sideRotation(theCube.bottom.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                nextMovesBuilderIndex++;

                //back counterClockwise
                //update the test cube
                sideRotation(theCube.back.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.back.counterClockwise;
                nextMovesBuilderIndex++;
            }
        }

        {
            //rotate the bottom until the blue-yellow square is in place
            while (theCube.colors[theCube.front.main[7]] != theCube.colors[theCube.front.main[4]])
            {
                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;
            }

            //swap across and right, then across and left until left is correct
            while (theCube.colors[theCube.right.main[7]] != theCube.colors[theCube.right.main[4]])
            {
                //right clockwise
                //update the test cube
                sideRotation(theCube.right.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //right counterclockwise
                //update the test cube
                sideRotation(theCube.right.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.counterClockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //right clockwise
                //update the test cube
                sideRotation(theCube.right.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //right counterclockwise
                //update the test cube
                sideRotation(theCube.right.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.counterClockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //front clockwise
                //update the test cube
                sideRotation(theCube.front.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.front.clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //front counterclockwise
                //update the test cube
                sideRotation(theCube.front.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.front.counterClockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //front clockwise
                //update the test cube
                sideRotation(theCube.front.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.front.clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //front counterclockwise
                //update the test cube
                sideRotation(theCube.front.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.front.counterClockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;
            }

            //swap across and right until both are correct
            while (theCube.colors[theCube.back.main[7]] != theCube.colors[theCube.back.main[4]])
            {
                //right clockwise
                //update the test cube
                sideRotation(theCube.right.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //right counterclockwise
                //update the test cube
                sideRotation(theCube.right.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.counterClockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //right clockwise
                //update the test cube
                sideRotation(theCube.right.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //right counterclockwise
                //update the test cube
                sideRotation(theCube.right.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.right.counterClockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;
            }
        }


        //search through the sides (sideIndexes[2-5]) for a side that contains a correctly-orientated square
        int sideOfInterest1 = -1;
        while (true)
        {
            for (int i = 2; i < 6; i++)
            {
                if (theCube.colors[sideIndexes[i].main[6]] == theCube.colors[sideIndexes[i].main[4]] || theCube.colors[sideIndexes[i].down[2]] == theCube.colors[sideIndexes[i].main[4]] || theCube.colors[sideIndexes[i].left[0]] == theCube.colors[sideIndexes[i].main[4]])
                {
                    if (theCube.colors[sideIndexes[i].main[6]] == theCube.colors[sideIndexes[i].left[1]] || theCube.colors[sideIndexes[i].down[2]] == theCube.colors[sideIndexes[i].left[1]] || theCube.colors[sideIndexes[i].left[0]] == theCube.colors[sideIndexes[i].left[1]])
                    {
                        sideOfInterest1 = i;
                        break;
                    }
                }
            }
            //if no side exists, perform the algorithm on a random side and try again
            //use sidIndexes[2] for the random side
            if (sideOfInterest1 == -1)
            {
                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //left-of-side clockwise
                //update the test cube
                sideRotation(sideIndexes[sideIndexes[2].leftOfSide].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[2].leftOfSide].clockwise;
                nextMovesBuilderIndex++;

                //bottom counterClockwise
                //update the test cube
                sideRotation(theCube.bottom.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                nextMovesBuilderIndex++;

                //right-of-side counterClockwise
                //update the test cube
                sideRotation(sideIndexes[sideIndexes[2].rightOfSide].counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[2].rightOfSide].counterClockwise;
                nextMovesBuilderIndex++;

                //bottom clockwise
                //update the test cube
                sideRotation(theCube.bottom.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
                nextMovesBuilderIndex++;

                //left-of-side counterClockwise
                //update the test cube
                sideRotation(sideIndexes[sideIndexes[2].leftOfSide].counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[2].leftOfSide].counterClockwise;
                nextMovesBuilderIndex++;

                //bottom counterClockwise
                //update the test cube
                sideRotation(theCube.bottom.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
                nextMovesBuilderIndex++;

                //right-of-side clockwise
                //update the test cube
                sideRotation(sideIndexes[sideIndexes[2].rightOfSide].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[2].rightOfSide].clockwise;
                nextMovesBuilderIndex++;
            }
            else
            {
                break;
            }
        }

        //while the rest of the squares are unsolved, perform the algorithm on the sideOfInterest1
        //use sideIndexes[sideOfInterest1] for the side
        while (!((theCube.colors[sideIndexes[sideOfInterest1].main[8]] == theCube.colors[sideIndexes[sideOfInterest1].main[4]] || theCube.colors[sideIndexes[sideOfInterest1].down[0]] == theCube.colors[sideIndexes[sideOfInterest1].main[4]] || theCube.colors[sideIndexes[sideOfInterest1].right[2]] == theCube.colors[sideIndexes[sideOfInterest1].main[4]]) && (theCube.colors[sideIndexes[sideOfInterest1].main[8]] == theCube.colors[sideIndexes[sideOfInterest1].right[0]] || theCube.colors[sideIndexes[sideOfInterest1].down[0]] == theCube.colors[sideIndexes[sideOfInterest1].right[0]] || theCube.colors[sideIndexes[sideOfInterest1].right[2]] == theCube.colors[sideIndexes[sideOfInterest1].right[0]])))
        {
            //bottom clockwise
            //update the test cube
            sideRotation(theCube.bottom.clockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
            nextMovesBuilderIndex++;

            //left-of-side clockwise
            //update the test cube
            sideRotation(sideIndexes[sideIndexes[sideOfInterest1].leftOfSide].clockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideOfInterest1].leftOfSide].clockwise;
            nextMovesBuilderIndex++;

            //bottom counterClockwise
            //update the test cube
            sideRotation(theCube.bottom.counterClockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
            nextMovesBuilderIndex++;

            //right-of-side counterClockwise
            //update the test cube
            sideRotation(sideIndexes[sideIndexes[sideOfInterest1].rightOfSide].counterClockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideOfInterest1].rightOfSide].counterClockwise;
            nextMovesBuilderIndex++;

            //bottom clockwise
            //update the test cube
            sideRotation(theCube.bottom.clockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = theCube.bottom.clockwise;
            nextMovesBuilderIndex++;

            //left-of-side counterClockwise
            //update the test cube
            sideRotation(sideIndexes[sideIndexes[sideOfInterest1].leftOfSide].counterClockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideOfInterest1].leftOfSide].counterClockwise;
            nextMovesBuilderIndex++;

            //bottom counterClockwise
            //update the test cube
            sideRotation(theCube.bottom.counterClockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
            nextMovesBuilderIndex++;

            //right-of-side clockwise
            //update the test cube
            sideRotation(sideIndexes[sideIndexes[sideOfInterest1].rightOfSide].clockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[sideOfInterest1].rightOfSide].clockwise;
            nextMovesBuilderIndex++;
        }

        //for every side (sideIndexes[2-5]), while bottom right is not orriented correctly, do the cycle algorithm
        for (int i = 0; i < 4; i++)
        {
            while (!(theCube.colors[sideIndexes[5].main[8]] == theCube.colors[sideIndexes[5].main[7]] && theCube.colors[sideIndexes[5].right[2]] == theCube.colors[sideIndexes[sideIndexes[5].rightOfSide].main[7]] && theCube.colors[sideIndexes[5].down[0]] == theCube.colors[sideIndexes[sideIndexes[5].downOfSide].main[4]]))
            {
                //top clockwise
                //update the test cube
                sideRotation(theCube.top.clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.top.clockwise;
                nextMovesBuilderIndex++;

                //right-of-side clockwise
                //update the test cube
                sideRotation(sideIndexes[sideIndexes[5].rightOfSide].clockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[5].rightOfSide].clockwise;
                nextMovesBuilderIndex++;

                //top counterClockwise
                //update the test cube
                sideRotation(theCube.top.counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = theCube.top.counterClockwise;
                nextMovesBuilderIndex++;

                //right-of-side counterClockwise
                //update the test cube
                sideRotation(sideIndexes[sideIndexes[5].rightOfSide].counterClockwise);
                //add the rotation to nextMoves
                nextMoves[nextMovesBuilderIndex] = sideIndexes[sideIndexes[5].rightOfSide].counterClockwise;
                nextMovesBuilderIndex++;
            }

            //rotate the bottom counterClockwise
            //update the test cube
            sideRotation(theCube.bottom.counterClockwise);
            //add the rotation to nextMoves
            nextMoves[nextMovesBuilderIndex] = theCube.bottom.counterClockwise;
            nextMovesBuilderIndex++;
        }

        //end nextMoves with 0 to indicate the end of the moves
        nextMoves[nextMovesBuilderIndex] = 0;
        nextMovesBuilderIndex++;
        //set up nextMoves to be read by displayNextMove
        nextMovesIndex = 0;
        //restore the original state of the cube
        colorsCopy.CopyTo(theCube.colors, 0);

        movesTotal = nextMovesBuilderIndex - 1;
        //Debug.Log(nextMovesBuilderIndex);
    }

    public void displayNextMove()
    {

        isSolving = true;

        //if the nextMove is 0, set nextMovesIndex to 0, re-enable every arrow,  and do nothing
        if (nextMoves[nextMovesIndex] == 0)
        {
            for (int i = 0; i < 12; i++)
            {
                arrows[i].SetActive(true);
            }
            isSolving = false;
            nextMovesIndex = 0;
            // re-enable the solve button
            theButton.interactable = true;
            // re-enable the scramble button
            scrambleButton.interactable = true;
            // re-enable the auto-solve button
            autoSolve.interactable = true;

            white.interactable = true;
            blue.interactable = true;
            orange.interactable = true;
            red.interactable = true;
            green.interactable = true;
            yellow.interactable = true;
            six.interactable = true;

            mover.mode = pastMode;

            return;
        }

        //enable the back button
        back.interactable = true;

        //disable every arrow except the one whose spinScript.turnType == nextMoves[nextMovesIndex]
        for (int i = 0; i < 12; i++)
        {
            if ( ((arrows[i]).GetComponent<spinScript>()).turnType == nextMoves[nextMovesIndex])
            {
                //enable the arrow
                arrows[i].SetActive(true);
                //set that arrow's calling indicator to indicate that it should call displayNextMove
                ((arrows[i]).GetComponent<spinScript>()).indicator = true;
            }
            else
            {
                //disable the arrow
                arrows[i].SetActive(false);
            }
        }

        //re-enable the auto-solve button
        autoSolve.interactable = true;

        string start = "move ";
        string soFar = (nextMovesIndex + 1).ToString();
        string movesString = " of ";
        string total = movesTotal.ToString();
        string completed = "";
        string concatenated = "";
        concatenated += start;
        concatenated += soFar;
        concatenated += movesString;
        concatenated += total;
        concatenated += completed;
        movesInputField.text = concatenated;

        //increase nextMoveIndex
        nextMovesIndex++;
    }

    public void autoDisplayNextMove()
    {
        isSolving = true;

        //if the nextMove is 0, set nextMovesIndex to 0, re-enable every arrow,  and do nothing
        if (nextMoves[nextMovesIndex] == 0)
        {
            for (int i = 0; i < 12; i++)
            {
                arrows[i].SetActive(true);
            }
            isSolving = false;
            nextMovesIndex = 0;
            // re-enable the solve button
            theButton.interactable = true;
            // re-enable the scramble button
            scrambleButton.interactable = true;
            // re-enable the auto-solve button
            autoSolve.interactable = true;

            white.interactable = true;
            blue.interactable = true;
            orange.interactable = true;
            red.interactable = true;
            green.interactable = true;
            yellow.interactable = true;
            six.interactable = true;

            mover.mode = pastMode;

            return;
        }

        //disable every arrow except the one whose spinScript.turnType == nextMoves[nextMovesIndex]
        for (int i = 0; i < 12; i++)
        {
            if (((arrows[i]).GetComponent<spinScript>()).turnType == nextMoves[nextMovesIndex])
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

        string start = "move ";
        string soFar = (nextMovesIndex + 1).ToString();
        string movesString = " of ";
        string total = movesTotal.ToString();
        string completed = "";
        string concatenated = "";
        concatenated += start;
        concatenated += soFar;
        concatenated += movesString;
        concatenated += total;
        concatenated += completed;
        movesInputField.text = concatenated;

        //increase nextMoveIndex
        nextMovesIndex++;
    }

    public void scramble()
    {
        //reset the cube's colors to normal
        //create the 54 element array of colors, according to the reference cube
        // 0 = white
        // 1 = blue
        // 2 = orange
        // 3 = green
        // 4 = red
        // 5 = yellow
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                int index = (i * 9) + j;
                theCube.colors[index] = i;
            }
        }

        for (int i = 0; i < 1000; i++)
        {
            //random number 1 - 12
            sideRotation(Random.Range(1, 12));
        }
        //updateColors();
    }
}
