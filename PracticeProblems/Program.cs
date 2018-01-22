using System;

namespace PracticeProblems
{
    class Program
    {
        static void Main()
        {
            // Create a program with your full name, favorite car, comic book hero

            // Just with Console
            //Console.WriteLine("Adrien Bardot");
            //Console.WriteLine("Bugatti Veyron");
            //Console.WriteLine("The Punisher");

            // Same concept with set variables
            //string firstName = "Adrien";
            //string lastName = "Bardot";
            //string favCar = "Bugatti Veyron";
            //string favComic = "The Punisher";
            //Console.WriteLine(firstName + lastName);
            //Console.WriteLine(favCar);
            //Console.WriteLine(favComic);

            // Same concept but now the user can add answers
            string firstName;
            string lastName;
            string favCar;
            string favComic;

            //The variable value is set to Console.ReadLine in order to take in the data from the user
            Console.WriteLine("What's you first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What's you last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("What's you favorite car?");
            favCar = Console.ReadLine();

            Console.WriteLine("What's you favorite comic book hero?");
            favComic = Console.ReadLine();

            //This method is used to skip a line in order to provide space between questions and answers
            Console.ReadLine();

            //First and last name output
            Console.WriteLine("Hello {0} {1}", firstName, lastName);

            //Favorite car output
            Console.WriteLine("Your favorite car is the {0}", favCar);

            // Favorite comic hero
            Console.WriteLine("Your favorite comic hero is {0}", favComic);
        }
    }
}
