using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("What is your grade percentage? (1-100) ");
        string valueFromUser = Console.ReadLine();
        double grade = double.Parse(valueFromUser);

        string letter;
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Remove decimals to get the last digit
        int wholeGrade = (int)Math.Floor(grade);
        int lastDigit = wholeGrade % 10;

        //Determine the + or - sign. 
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle special cases
        if (letter == "A")
        {
            if (grade >= 93)
            {
                sign = "";
            }
            else if (sign == "+")
            {
                sign = "";
            }
        }

        if (letter == "F")
        {
            sign = "";
        }

        // Print final result
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Pass or fail message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass this time. Keep trying next time!");
        }

    }
}