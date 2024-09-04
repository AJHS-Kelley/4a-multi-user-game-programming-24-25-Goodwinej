using System;
class FlowControlStructures {
  static void Main() {
    // These blocks of code are used to control how the program executes.
    // basically, these blocks of code allow for desicions to be made.

    // int age = 17;
    // double cheeseburgers = 1.25D; //HAVE TO HAAVE THE D AT THE END OF DOUBLE
    // string favFlavor = "red velvet";
    // bool afraidSnakes = false;

    // // Can I vote?
    // if (age >= 18) // (age >= 18) is the conditional statement
    // {
    //   Console.WriteLine('You can vote.');
    // }
    // else if (age >= 16) // check this NEXT if line #13 is false.
    // {
    //   cosnole.WriteLine('You are not old enough to vote BUT you Can register.' \n);
    // }
    // else
    // {
    //   Console.WriteLine ('You ar enot old enough to vote OR register. \n');
    // }

  



    // int day = 1;
    // switch(day)
    // {
    //   case 1:
    //       Console.WriteLine("It's monday.\n");
    //       break;
    //   case 2:
    //       Console.WriteLine("It's tuesday.\n");
    //       break;
    //   caser 3:
    //       Console.WriteLine("It's wednesday.\n");
    //       break;
    //   case 4:
    //       Console.WriteLine("It's thursday.\n");
    //       break;
    //   case 5:
    //       Console.WriteLine("it's friday.\n");
    //       break;
    //   case 6:
    //       Console.WriteLine("It's saturday.\n");
    //       break;
    //   case 7:
    //       Console.WriteLine("it's sunday, go rest.\n");
    //       break;     
    
    // }

  // Repeating STEPS OVER, AND OVEr, AND OVER AGAIN
  // LOOPS are used to repeat instructions multiple times.

  // while loops are "musicsl chairs" pf coputer science.
  // the code will run as long as the conditions are true
  //while loop syntax:
  /*

  // while (CONDITIONAL_EXPRESSION)
  {
     CODE TO LOOP GOES HERE
  }
  */

  //   int Z = 0;
  //   while (z <= 100) // WHAT DO I REPLACE cONDITIONAL_EXPRESSION WITH?
  // {
  //   Console.WriteLine(z);
  //   z++;
  // }

  // int y = 100;
  //   while (y >= 0) // WHAT DO I REPLACE cONDITIONAL_EXPRESSION WITH?
  // {
  //   Console.WriteLine(y);
  //   y--;
  // }
   
  // for loops are like playing go fish.
  // you know how many cards are in you hand.
  // used when you know how many loops you need ahead of time.

  /*
  for (statements1; statement2; statement3)
  
  }
  {
    code to run each time through loop.
  }
  statement1 = code to run ONE TIME before the loop starts.
  statement2 = CONDITIONAL EXPRESSION to check EACH TIME before loop runs.
  statement3 = code to run AFTER each loop.

  Each 'trip' through the loop is called an ITERATION.
  */

  // counting to 10
  for (int i = 0; i <= 10; i++)
  {
    Console.WriteLine(i);
  }

  //test
}
