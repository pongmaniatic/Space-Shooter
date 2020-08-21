using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentOne : MonoBehaviour
{
    //this 
    private int Problem1 = 0;
    private string Answer1;
    private void Start()
    {
        Answer1 = EvenOrOdd(Problem1); // this activates the script to solve the first problem
        Debug.Log(Answer1); // this shows the answer on the console
    }

    private string EvenOrOdd(int Number) // this function recives an int and returns a string that tells if the in is even or odd
    {
        if (Number % 2 == 0){return ("Even"); } //this divides  the number by 2 and returns 0 if the resulting number is whole like 4.0
        if (Number % 2 == 1){return ("Odd"); } //This divides the int by 2 and returns 1 if the resulting number has residue numbers like 4.5
        return ("Error"); // this is in case it all fails, it should be inpossible, but the function requires it. 
        //Because of how math works, an even devided by 2, is always whole, and an odd divided by 2
    }
}
