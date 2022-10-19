using System;

int number = 246;  //enter a number in here
int startingNumber = number; // storing here for printing purpose
bool flag = true;  //for resetting the main program
int modNum = 2, numCount = 0;
string str = "";

while (flag)
{
    Console.WriteLine("Enter a number to find all its prime factors:");
    string inputText = Console.ReadLine();

    try
    {
        number = int.Parse(inputText);

        //Algorithm start here
        while (number > modNum)
        {
            if (0 == number % modNum)
            {                                                                                                                                                                          
                number = number / modNum;
                numCount++;

            }
            else  //reset number count, and increase mod by 1
            {
                if (numCount != 0)
                {
                    str += "(" + modNum + "**" + numCount + ")"; // string
                }
                numCount = 0;
                modNum++;
            }
        }

        Console.WriteLine("Number is " + startingNumber + ", all prime factors: " + str + "(" + number + ")");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    //Restarting the loop
    Console.WriteLine("One more time? (Y/y)");
    inputText = Console.ReadLine();
    if (inputText == "y" || inputText == "Y")
    {
        flag = true;
        Console.Clear();
    }
    else
    {
        flag = false;
    }
}