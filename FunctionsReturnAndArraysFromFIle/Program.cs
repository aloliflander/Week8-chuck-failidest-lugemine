using System;

namespace FunctionsReturnAndArraysFromFIle
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }
        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);
            string randomfood = foods[randomIndex];
            Console.WriteLine($"Computer picked; {randomfood}");
        }
        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);
            string randomdrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked; {randomdrink}");
        }
        private static void DisplayRandomMovie()
        {
            string[] movies = { "Mr. Bean", "Friends", "Die Hard", "Home Alone"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);
            string randomMovie = movies[randomIndex];
            Console.WriteLine($"Computer picked; {randomMovie}");
        }
    }
}
