using System;

namespace Arrays_practice_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool infoLoop = true;


            string[] names = { "", "Sean", "Justin", "Jean", "Alice", "Kristen", "Kalai", "Jason","Kamesha" };
            string[] places = { "", "Plymouth", "Wyoming", "Lascahobas", "Detroit", "Orange Park", "Troy", "Courtright","Detroit" };
            string[] food = { "", "Pizza", "Baja Blast", "Fritay", "Sushi", "Mac&Cheese", "Dosa", "Mac&Cheese", "Tacos" };
            bool validInput = true;
            int choice;




            do
            {
                while (true)
                {
                    Console.WriteLine("Please enter a number 1-8 to learn about a student");//get student number
                    choice = int.Parse(Console.ReadLine());
                    if (choice > 8 || choice <= 0)
                    {
                        Console.WriteLine("Invalid input");
                    } else
                    {
                        break;
                    }
                }

                for (int i = 0; i <= names.Length; i++)
                {
                    if (i == choice)
                    {
                        Console.WriteLine($"Students name is {names[i]} ");//display student name based on number
                        while (validInput)
                        {
                            Console.WriteLine("Would you like to learn their hometown or favfood?");//ask food or hometown
                            string info = Console.ReadLine();
                            if (info == "hometown")
                            {
                                Console.WriteLine($"{names[choice]}'s hometown is {places[i]}");
                                break;
                            }
                            else if (info == "favfood")
                            {
                                Console.WriteLine($"{names[i]}'s favorite food is {food[i]}");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("invalid answer");
                            }
                        }

                        Console.WriteLine("Would you like to learn about another student? y/n");
                        string keepGoing = Console.ReadLine();
                        if (keepGoing == "n")
                        {
                            infoLoop = false;
                            break;
                        }
                        else if (keepGoing == "y")
                        {
                            break;
                        }

                    }
                }


            } while (infoLoop);






        }


    }
}
