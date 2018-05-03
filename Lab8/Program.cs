using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //use 3 arrays. store name, hometown, and favorite food
            //string[] names = {"_","_","_",.........};
            //extra challenge make the program able to search for names instead of just numbers
            //ask user for number or name
            //ask user for piece of information they're looking for name or hometown
            //continue or do again
            //add validation
            bool repeat = true;//run program again
            while (repeat)
            {
                int studentNumber;
            string[] studentNames = { "Melodie", "Kathy", "Chris", "Frank", "Ethan", "Anthony", "John", "Tiffany", "Nick", "Julio" };
            string[] favoriteFood = { "sushi", "cereal", "pizza", "noodles", "tacos", "chips", "chipotle", "rice", "broccoli", "yogurt" };
            string[] hometown = { "New York", "Chicago", "San Francisco", "Washington, DC", "Boston", "Detroit", "Los Angeles", "Seattle","Rochester", "Miami" };
                try
                {
                    //input
                    Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about?(Enter a number between 1-10)");
                    studentNumber = int.Parse(Console.ReadLine());

                    for (int i = 0; i < studentNames.Length; i++)
                    {
                        if (studentNumber - 1 == i)
                        {
                            Console.WriteLine("You chose:" + studentNames[studentNumber - 1]);
                            Console.WriteLine($"Would you like to know {studentNames[studentNumber - 1]}'s hometown or favorite food?");
                            string infoInput = Console.ReadLine().ToLower();
                            if (infoInput == "hometown")
                            {
                                Console.WriteLine($"{studentNames[studentNumber - 1]}'s hometown is {hometown[studentNumber - 1]}.");
                            }
                            else if (infoInput == "favorite food")
                            {
                                Console.WriteLine($"{studentNames[studentNumber - 1]}'s favorite food is {favoriteFood[studentNumber - 1]}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input");
                            }
                        }
                    }
                    repeat = Confirm("Do you want to continue? (y/n)");
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("The input you entered is out of range.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input you entered isn't valid");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
        }
        public static bool Confirm(string message)//validation for restart program msg
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                return true;
            }
            else if (input.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                return Confirm(message);
            }
        }
    }
}
