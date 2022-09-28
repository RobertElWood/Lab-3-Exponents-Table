using System;

public class Program
{

    public static void Main()
    {

        bool goOn = true;   //boolean value which controls the while loop. While goOn = true, the loop will run.

        Console.WriteLine("Welcome to the exponent table generator!\n");

        while (goOn)
        {
            Console.Write("\nPlease enter an integer: "); int num1 = int.Parse(Console.ReadLine()); //User enters their input, which is parsed to an int.


            if (num1 >= 1290) //if the number's cube is too large to be held as an int, will prompt user to re-enter.
            {
                Console.WriteLine("\nThat number is too large. Please input a smaller number.");
                continue;
            }
            else if (num1 < 0) //if the number is negative, will prompt the user to re-enter a number. 
            {
                Console.WriteLine("\nPlease enter a positive number that is greater than 0.");
                continue;
            }
            else if (num1 > 0) //if the number is a positive number, the program will continue.
            {
                Console.WriteLine("\n Number\t" + "Squared\t" + "  Cubed");
                Console.WriteLine("=======\t" + "=======\t" + "=======");
            }


            for (int i = 1; i <= num1; i++) //Iterates up to the number the user entered, calculating the square and cube of each number entered.
            {
                int num = i;
                int numSquare = i * i;
                int numCube = i * i * i;

                string tableList = String.Format("{0,7}" + "\t" + "{1,7}" + "\t" + "{2,7}", num, numSquare, numCube); //formats the table to be printed, line by line.
                Console.WriteLine (tableList); //prints the table of generated data.
            }

            goOn = askAgain(); //calls method to control aforementioned boolean value for more runs of the loop.
        }
        
    }
    public static bool askAgain() //Boolean method to discern whether or not user should continue.
    {
        Console.WriteLine("\nWould you like to test another number? Y/N?\n");
        string input = Console.ReadLine().ToLower();

        if (input == "y")
        {
            return true;
        } 
        else if (input == "n")
        {
            Console.WriteLine("\nGoodbye!");
            return false;
        } 
        else
        {
            Console.WriteLine("I didn't understand that. Please try again!");
            return askAgain();
        }
    }
}