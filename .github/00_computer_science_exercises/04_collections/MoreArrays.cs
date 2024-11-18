using System;
class MoreArrays {
  static void Main() {

    string[] colors = {"Garnet", "Gold", "Purple", "Teal", "fuschia"};
    // LOOPING THROUGH ARRAYS -- Old way
    for (int i = 0; i < colors.Length i++)
    {
        Console.WriteLine(colore[i]);
    }

    // LOOPING THROUGH THE ARRAYS -- NEW WAY
    foreach (atring i in colors)
    {
        Console.WriteLine(i);
    }

    // LOOPING THROUGH ARRAY PRACTICE
    int[] numbers = {-10, 25, -345, 45, 9999, 1,0, 68, 538, -99999};
    foreach (int i in numbers[i]);
    {
        Console.WriteLine(i);
        if (i % 2 == 0)
        {
            Console.WriteLine("This Number is even")
        }
        else
        {
            Console.writeLine("This number is odd.")
        }
    }

    // MULTIDEMNSIONAL ARRAYS
    // Thia class will only use 2 dimensional arrays.
    int[,] nums = {{2, 2, 4}, {1, 2, 6}};

    // ACCESSING ELEMENTS IN 2D ARRAYS
    Console.WriteLine(nums[0,1]);
    Console.WriteLine(nums[1,1]);

    // CHANGING ELEMENTS IN 2D ARRAYS
    nums[1,2] = 9001;
    // CHANGE ANY ELEMENT FROM THE FIRST ARRAY
    nums[0, 2] =502;

    // LOOPING THROUGH 2D ARRAYS
    foreach (int i in nums)
    {
        Console.WriteLine(i);
    }

    //LOOPING THROUGH 2D ARRAYS -- HARD MODE
    for (int i= 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.WriteLine(nums[i, j]);
        }
    }
    
  } // DO NOT DELETE THIS EVER!! 3 spaces indented from the left.
} // DO NOT DELETE THID EVER, ALWASY TOUCHING LEFT MARGIN.