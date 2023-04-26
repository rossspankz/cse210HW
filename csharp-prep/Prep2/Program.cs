using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade big dog?");
        string x = Console.ReadLine();
        int y = int.Parse(x);
        string grade = "N";


        if(y >= 90 && y <= 110)
        {
            grade = "A";
        }

        if(y >= 80 && y < 90)
        {
            grade = "B";
        }

        if(y >= 70 && y < 80)
        {
            grade = "C";
        }

        if(y >= 60 && y < 70)
        {
            grade = "D";
        }

        if(y >= 0 && y < 60)
        {
            grade = "F";
        }
       if(y> 110 || y< 0)
       {
        Console.WriteLine("Invalid grade.");
       }


        if( grade == "A")
        {
             Console.WriteLine($"Your Grade is an {grade}.");
        }
        if(grade == "B" || grade == "C" || grade == "D" || grade == "F")
        {
            Console.WriteLine($"Your Grade is a {grade}.");
        }
        
        if( grade == "A"|| grade == "B" || grade == "C" )
        {
            Console.WriteLine("Congrats big man you passed!!!");
        }
        if(grade == "D" || grade == "F")
        {
            Console.WriteLine("Better Luck next semester kid :(");
        }
        if (y> 110 || y< 0)
        {
            Console.WriteLine("Try again");
        }
    }
}
