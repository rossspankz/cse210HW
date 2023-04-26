using System;

class Program
{
    static void Main(string[] args)
    {
         DisplayWelcome();

        string nombre = PromptUserName();
            
        int y = PromptUserNumber();

        int root = SquareNumber(y);

        DisplayResult(nombre, root);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            int num = int.Parse(Console.ReadLine());

            return num;

        }

        static int SquareNumber(int num)
        {
            int square = num * num;
            
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

       
    }
}
