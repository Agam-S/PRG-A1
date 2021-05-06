using System;
using System.Collections.Generic;
using System.Linq;

namespace A1
{
    class Program
    {
        public static int RolltheDice()
        {
        int counter = 0;
        System.Console.WriteLine("Press Enter to roll the Dice");
        Console.ReadLine();
    
        System.Console.WriteLine("Press Enter how many times do you want to roll the dice :");
        int num = int.Parse(Console.ReadLine());

        Random random = new Random();
        int dice = random.Next(1, 6);
        List<int> list = new List<int>();

        while (num > counter) {
        counter++;
        System.Console.WriteLine("ROLLING DICE THORUGH 1 to 6 ::::::");
        System.Console.WriteLine();
        System.Console.WriteLine("Dice number is.... BAM " + dice);
        System.Console.WriteLine("Do you wish to continue the rolls? Please Type 'Stop' if you don't wanna continue: ");
        string ans = Console.ReadLine();
        
        if (ans == "Stop") {
            System.Console.WriteLine("Thanks for Playing");
            break;
        }
        list.Add(dice);
        int sum = list.Sum();
        double avg = list.Average();
        System.Console.WriteLine("Your Past Rolls were : ");
        foreach(int thing in list)
        {
            Console.Write(" " + thing + " ");
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Sum is: " + sum);
        System.Console.WriteLine("Avg is: " + avg);
       }
        
        Again();
        return dice;
        }
        
        static void Main(string[] args)
        {   
            Console.WriteLine("Hey there! This is a dice rolling game ");
            RolltheDice();
        
        }

        public static void Again()
        {
            System.Console.WriteLine("Do you want to Play again? - Answer - Y/N ");
            string choice = Console.ReadLine();

            if (choice == "Y") {
            RolltheDice();
            }
            if (choice == "N") {
            System.Console.WriteLine("Thanks for playing");
            }
        }
    
    }
}
