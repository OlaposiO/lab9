using System;

using System.Collections.Generic;



namespace GetToKnowYourClassmates

{

    class Program

    {

        static void Main(string[] args)

        {
            string start = "";
            string finalGo = StundentNumber(start);
            Console.WriteLine(finalGo);

        }

        public static string StundentNumber(string input)
        {
            bool goodToGo = false;
            int num = 0;
            string name;
            Console.WriteLine("What student what you like to learn more about? (Pick a number between 1-10)");
            string userNumber = Console.ReadLine();
            int.TryParse(userNumber, out int number);
            do
            {


                if ((number > 0) && (number <= 10))
                {
                    goodToGo = false;
                    num = number;
                }
                else
                {
                    Console.WriteLine("That student does not exisit.(Pick 1-10)");
                    goodToGo = true;
                }

            } while (goodToGo);

            List<string> students = new List<string> { "aFiller", "James", "Robert", "Ollie", "Ed", "Sarah", "Edward", "Nick", "Vlad", "Victoria", "Zach" };

            students.Sort();
            name = students[num];

            List<string> food = new List<string> { "AFiller", "pie", "Cheese", "Sharwarma", "Tacos", "Cheese Sticks", "Pizza", "Greens", "Bananas", "Pasta", "Potato Salad" };
            List<string> hometown = new List<string> { "AFiller", "Detoit", "Cleveland", "Dallas", "Atlana", "Seattle", "Oakland", "LA", "Flint", "Ypsilanti", "Royal Oak" };
            List<int> age = new List<int> { 23, 28, 27, 31, 36, 25, 32, 45, 34, 21, 25 };
            string info = "";

            Console.WriteLine($"This Student is {name}. What would you like to know about {name}? enter 'Hometown' or 'Favorite Food'");
            string userInput = Console.ReadLine();
            do
            {




                if ((userInput == "Hometown") || (userInput == "hometown"))
                {
                    goodToGo = false;
                    info = hometown[num];
                    Console.WriteLine($"{name}'s hometown is {info}");
                }
                else if ((userInput == "Favorite Food") || (userInput == "favorite food"))
                {
                    goodToGo = false;
                    info = food[num];
                    Console.WriteLine($"{name}'s favorite food is {info}");
                }
                else
                {
                    Console.WriteLine("That data does not exist.(Please try again)");
                    goodToGo = true;
                }
            } while (goodToGo);

            Console.WriteLine("would you like more information? [yes/no]");
            string answer = Console.ReadLine();

            if ((answer == "yes") || (answer == "Yes"))
            {
                do
                {
                    Console.WriteLine($"What would you like to know about {name}? enter 'Hometown' or 'Favorite Food'");
                    string newUserInput = Console.ReadLine();


                    if ((newUserInput == "Hometown") || (newUserInput == "hometown"))
                    {
                        goodToGo = false;
                        info = hometown[num];
                        Console.WriteLine($"{name}'s hometown is {info}");
                    }
                    else if ((newUserInput == "Favorite Food") || (newUserInput == "favorite food"))
                    {
                        goodToGo = false;
                        info = food[num];
                        Console.WriteLine($"{name}'s favorite food is {info}");
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist.(Please try again)");
                        goodToGo = true;
                    }
                } while (goodToGo);
            }
            else
            {
                Console.WriteLine("You either said no over made an typo. Good night!");
            }

            Console.WriteLine("Would you like even more information? [yes/no]");
            string newAnswer = Console.ReadLine();

            if ((newAnswer == "yes") || (newAnswer == "Yes"))
            {
                Console.WriteLine($"{name} is {age[num]} years old. I think");
            }
            else
            {
                Console.WriteLine("You either said no over made an typo. Good night!");
            }

            return "good bye!";
        }

    }

}