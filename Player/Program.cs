using System;
using System.Collections.Generic;

class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a generic list of players
        List<Player> players = new List<Player>
        {
            new Player { Id = 1, Name = "John Doe" },
            new Player { Id = 2, Name = "Jane Smith" },
            new Player { Id = 3, Name = "Bob Johnson" }
        };

        // Create an instance of the PlayerManager class
        PlayerManager playerManager = new PlayerManager(players);

        // Display menu options
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Display all players");
            Console.WriteLine("2. Display player by ID");
            Console.WriteLine("3. Exit");

            // Get user choice
            Console.Write("Enter your choice (1, 2, or 3): ");
            if (int.TryParse(Console.ReadLine(), out int userChoice))
            {
                switch (userChoice)
                {
                    case 1:
                        // Display all players
                        Console.WriteLine("All Players:");
                        playerManager.DisplayAllPlayers();
                        break;

                    case 2:
                        // Display player by ID
                        Console.Write("Enter player ID to display: ");
                        if (int.TryParse(Console.ReadLine(), out int playerId))
                        {
                            playerManager.DisplayPlayerById(playerId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid numeric ID.");
                        }
                        break;

                    case 3:
                        // Exit the program
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric choice.");
            }
        }
    }
}

class PlayerManager
{
    private List<Player> players;

    public PlayerManager(List<Player> players)
    {
        this.players = players;
    }

    // Display all players in the list
    public void DisplayAllPlayers()
    {
        foreach (var player in players)
        {
            Console.WriteLine($"ID: {player.Id}, Name: {player.Name}");
        }
        Console.WriteLine();
    }

    // Display player by ID
    public void DisplayPlayerById(int playerId)
    {
        Player foundPlayer = players.Find(p => p.Id == playerId);
        if (foundPlayer != null)
        {
            Console.WriteLine($"Player found - ID: {foundPlayer.Id}, Name: {foundPlayer.Name}");
        }
        else
        {
            Console.WriteLine($"Player with ID {playerId} not found.");
        }
    }
}
