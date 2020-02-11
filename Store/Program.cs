using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // ask question
            Console.WriteLine("What's your name?");

            // read answer
            string input = Console.ReadLine();

            // repeat answer
            Console.WriteLine(input + ", really?");
            Console.WriteLine("{0}, really?", input);

            // wait for fonfirmation to quit
            Console.ReadLine();
            */

            // Buying
            Store store = new Store();
            Console.WriteLine("Welcome to our store!");

            while (true)
            {
                // Buy a game, see which games are there, quit the store, see descriptions. 
                Console.WriteLine("Please Enter Commands: (quit/show/buy)");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "quit":
                        Environment.Exit(0);
                        break;
                    case "show":
                        store.showcase.Show();
                        break;
                    case "buy":
                        // ask which game
                        Console.WriteLine("Which games would you wish to buy?");
                        string selectedGame = Console.ReadLine();
                        int gameIndex = Convert.ToInt32(selectedGame);
                        string gameName= null;

                        if (gameIndex < store.showcase.games.Count)
                            gameName = store.showcase.games[gameIndex].name;

                        // remove it from showcase, or tell the user it's not a valid game
                        if (store.showcase.RemoveGame(gameIndex))
                            Console.WriteLine("You have succesfully bought: " + gameName);
                        else
                            Console.WriteLine("Your purchase wasn't succesfull.");

                        break;
                    default:
                        Console.WriteLine("I don't understand");
                        break;
                }
            }
        }
    }
}
