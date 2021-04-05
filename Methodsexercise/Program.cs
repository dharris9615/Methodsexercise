using System;

namespace Methodsexercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }


        static void Main(string[] args)
        {

            var amountOfTeams = Sum(2, 6);
            var money = Multiply(3, 10, 5);



            Console.WriteLine("Hello What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName} What is your favorite sport?");
            var sport = Console.ReadLine();

            Console.WriteLine($"{sport} is a fun sport to watch! Who's your favorite team?");
            var team = Console.ReadLine();

            Console.WriteLine($"{team} have a good team! Who's there headcoach");
            var headcaoch = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName} here is your favorite sports recap!");
            Console.WriteLine("------------------------");

            Console.WriteLine($"Name: {userName} ");
            Console.WriteLine($"Favorite sport: {sport}");
            Console.WriteLine($"Favorite team: {team}");
            Console.WriteLine($"Headcoach: {headcaoch}");

        }
    }
}
