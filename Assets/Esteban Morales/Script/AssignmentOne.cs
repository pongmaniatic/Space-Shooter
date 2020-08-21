using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AssignmentOne : MonoBehaviour
{
    /*
    // The initial input and the answer for the first problem.
    public int Problem1 = 321;
    private string Answer1;
    // The initial input and the answer for the second problem.
    public int MaxLimit = 10;
    public int MinLimit = 5;

    // The initial input and the answer for the third problem.
    private int[] OriginalArray = {3,5,1,8};
    // The initial input and the answer for the forth problem.
    public int Minn = 1;
    public int Maxx = 10;
    // The initial input and the answer for the fifth problem.
    public int intA = 3;
    public int intB = 5;

    private void Start()
    {
        //Problem 1
        Answer1 = EvenOrOdd(Problem1); // this activates the script to solve the first problem
        Debug.Log("Problem 1");
        Debug.Log("the number "+ Problem1.ToString() + " is " + Answer1 ); // this shows the answer on the console

        //Problem 2
        Debug.Log(" ");
        Debug.Log("Problem 2");
        CreateRandomArray(MinLimit, MaxLimit);


        //Problem 3
        Debug.Log(" ");
        Debug.Log("Problem 3");
        ReverseArray(OriginalArray);

        //Problem 4
        Debug.Log(" ");
        Debug.Log("Problem 4");
        FizzBuzz(Minn, Maxx);

        //Problem 5
        Debug.Log(" ");
        Debug.Log("Problem 5");
        SwapVariables(intA, intB);
    }

    private string EvenOrOdd(int Number) // this function recives an int and returns a string that tells if the in is even or odd.
    {
        if (Number % 2 == 0) { return ("Even"); } //this divides  the number by 2 and returns 0 if the resulting number is whole like 4.0.
        if (Number % 2 == 1) { return ("Odd"); } //This divides the int by 2 and returns 1 if the resulting number has residue numbers like 4.5.
        return ("Error"); // this is in case it all fails, it should be inpossible, but the function requires it. 
    }


    void CreateRandomArray(int min, int max) // this function takes 2 values, a minimum and a maximum, and uses those values to create an array of the correct size.
    {
        Debug.Log("Minimum value = " + min);
        Debug.Log("Maximum value = " + max);
        int[] NewArray = { 0, 0, 0, 0, 0, 0 };
        int smallest = max;
        int Biggest = min;
        for (int i = 0; i < 6; i++)
        {
            NewArray[i] = Random.Range(min, max);
            if (NewArray[i] > Biggest)
            {
                Biggest = NewArray[i];
            }
            if (NewArray[i] < smallest)
            {
                smallest = NewArray[i];
            }
            Debug.Log(NewArray[i]);
        }
        Debug.Log(smallest + " is the lowest value and " + Biggest + " is the highest value");
    }

    void ReverseArray(int[] originalArray) // this function takes 2 values, a minimum and a maximum, and uses those values to create an array of the correct size.
    {
        int lenghtOfList = originalArray.Length;

        Debug.Log("orignial array:");
        for (int i = 0; i < lenghtOfList; i++)
        {
            Debug.Log(originalArray[i]);
        }


        Debug.Log("reversed array:");
        for (int i = 0; i < lenghtOfList; i++)
        {
            Debug.Log(originalArray[lenghtOfList-1-i]);
        }


    }

    void FizzBuzz(int min, int max)
    {

        Debug.Log("Minimum value = "+ min + ", maximum value = "+ max + ". ");
        int lenght = max - min; 
        int baseNumber = min;
        for (int i = 0; i < lenght+1; i++)
        {
            int Multiple3 = baseNumber % 3;
            int Multiple5 = baseNumber % 5;

            if (Multiple3 == 0)
            {
                if (Multiple5 == 0)
                {
                    Debug.Log("FizzBuzz");
                }
                else
                {
                    Debug.Log("Fizz");
                }
            }
            if (Multiple5 == 0)
            {
                Debug.Log("Buzz");
            }

            if (Multiple3 != 0 && Multiple5 != 0) 
            {
                Debug.Log(baseNumber);
            }


            baseNumber += 1;

        }
    }


    void SwapVariables(int A, int B)
    {
        int C = B;
        int D = A;
        intA = C;
        intB = D;

        Debug.Log("Number A = " + A);
        Debug.Log("Number B = " + B);


        Debug.Log("Value of variable A is now " + B + " and value of variable B is now " + A +". ");

    }


    */

}
