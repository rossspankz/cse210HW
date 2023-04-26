using System;

class Program
{
    static void Main(string[] args)
    {
        string answer;

        do
        {
            
        
            Random randomGenerator = new Random();
            int x = randomGenerator.Next(1,100);

            Console.WriteLine("What is your guess? ");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x != z)
            {     
                if (x > z)
                {
                    Console.WriteLine("Higher");
                }

                else if (x < z)
                {
                    Console.WriteLine("Lower");
                }   
            
                do
                {
                    Console.WriteLine("What is your guess? ");
                    z = Convert.ToInt32(Console.ReadLine());

                    if (x > z)
                    {
                        Console.WriteLine("Higher");
                    }

                    else if (x < z)
                    {
                        Console.WriteLine("Lower");
                    }

                } while(x != z);
            }
            if (z == x)
            {
                Console.WriteLine("You guessed it!");
            }

            Console.WriteLine("Do you want to play again? ");
            answer = Console.ReadLine();

               

        
        }while (answer == "yes" || answer == "Yes" || answer == "Yeah" || answer == "Y" || answer == "y");
    }
}
