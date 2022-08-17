using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int awardpoints;
            int score = 0;
            awardpoints = 1;
            Console.WriteLine();
            Console.WriteLine("What animal is a feline? ");
            Console.WriteLine("  a) Dog");
            Console.WriteLine("  b) Elephant");
            Console.WriteLine("  c) Cat");
            Console.WriteLine("  d) Bird");
            Console.Write("Your answer: ");
            answer = Console.ReadLine();

            if (answer == "c")
            {
                score += awardpoints;
                Console.WriteLine("Correct! Score = " + awardpoints, score);
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
            }
            else if (answer != "a" + "b" + "d")
            {
                Console.WriteLine("Incorrect " + "Press Enter...");
                Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("What was the first soft drink in soace?");
            Console.WriteLine("  a) Coca Cola");
            Console.WriteLine("  b) Sprite");
            Console.WriteLine("  c) Fanta");
            Console.WriteLine("  d) Pepsi");
            Console.Write("Your answer: ");
            answer = Console.ReadLine();

            if (answer == "a")
            {
                score += awardpoints;
                Console.WriteLine("Correct! Score = " + awardpoints, score);
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
            }
            else if (answer != "b" + "c" + "d")
            {
                Console.WriteLine("Incorrect " + "Press Enter...");
                Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("What color is a giraffe's tounge??");
            Console.WriteLine("  a) Blue");
            Console.WriteLine("  b) Pink");
            Console.WriteLine("  c) Red");
            Console.WriteLine("  d) Purple");
            Console.Write("Your answer: ");
            answer = Console.ReadLine();

            if (answer == "d")
            {
                score += awardpoints;
                Console.WriteLine("Correct! Score = " + awardpoints, score);
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
            }
            else if (answer != "a" + "b" + "c")
            {
                Console.WriteLine("Incorrect " + "Press Enter...");
                Console.ReadLine();
            }
            Console.WriteLine("Final score = " + score);
            Console.ReadLine();
        }
    }
}