using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string x;
        int y;
        List<int> num = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {
            Console.WriteLine("Enter a number: "); x = Console.ReadLine();
        y = int.Parse(x);
        
        if (y!=0)
           { 
            num.Add(y);
           }

        }while(y != 0);
        
        double sum = num.AsQueryable().Sum();
        double av = Queryable.Average(num.AsQueryable());


        Console.WriteLine("The sum is: "+sum); 
        Console.WriteLine("The average is: "+av); 
        Console.WriteLine("The Largest number is: " + num.Max()); 


    }
}
