using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text.Json;


// string jsonString = File.ReadAllText("saveGame.json");
// SaveData? data = JsonSerializer.Deserialize<SaveData>(jsonString);



internal class Program
{
  static int PlayerWins = 0;
  static int ComputerWins = 0;

  // static void SaveGame()
  // {
  //   SaveData? save = new(PlayerWins, ComputerWins);
  //   string saveData = JsonSerializer.Serialize(save);
  //   File.WriteAllText("saveGame.json", saveData);
  // }



  // static void LoadGame()
  // {
  //   string jsonString = File.ReadAllText("saveGame.json");
  //   SaveData data = JsonSerializer.Deserialize<SaveData>(jsonString);
  //   if (data != null)
  //   {
  //     PlayerWins = data.PlayerWins;
  //     ComputerWins = data.ComputerWins;
  //   }
  // }

  private static void Main()
  {
    // LoadGame();
    Console.Clear();
    Console.WriteLine($"Player has {PlayerWins} points, Computer has {ComputerWins} points!");
    Console.WriteLine("Rock, Paper, Scissors");
    string userHand = ChooseHand();
    string computerHand = GetComputerHand();
    Console.WriteLine($"You chose {userHand}");
    Console.WriteLine($"Computer chose {computerHand}");

    if (userHand == "rock" && computerHand == "scissors")
    {
      Console.WriteLine($"{userHand} wins and player has {PlayerWins} points!");
      PlayerWins += 1;
    }
    if (userHand == "scissors" && computerHand == "paper")
    {
      Console.WriteLine($"{userHand} wins and player has {PlayerWins} points!");
      PlayerWins += 1;
    }
    if (userHand == "paper" && computerHand == "rock")
    {
      Console.WriteLine($"{userHand} wins and player has {PlayerWins} points!");
      PlayerWins += 1;
    }



    if (computerHand == "rock" && userHand == "scissors")
    {
      Console.WriteLine($"{computerHand} wins and computer has {ComputerWins}!");
      ComputerWins++;
    }
    if (computerHand == "scissors" && userHand == "paper")
    {
      Console.WriteLine($"{computerHand} wins and computer has {ComputerWins}!");
      ComputerWins++;
    }
    if (computerHand == "paper" && userHand == "rock")
    {
      Console.WriteLine($"{computerHand} wins and computer has {ComputerWins}!");
      ComputerWins++;
    }
    if (userHand == computerHand)
      Console.WriteLine($"{userHand} & {computerHand} tied this round!");



    Console.WriteLine("Would you like to play again? y or n?");
    var userInput = Console.ReadKey().KeyChar;

    if (userInput == 'y')

      Main();
    if (userInput == 'n')
      Environment.Exit(0);
    // SaveGame();

  }

  static string ChooseHand()
  {
    Console.WriteLine("Choose A Hand");
    Console.WriteLine("1. Rock");
    Console.WriteLine("2. Paper");
    Console.WriteLine("3. Scissors");


    string? userInput = Console.ReadLine();
    if (userInput == null)
      return ChooseHand();
    if (userInput == "1")
      return "rock";
    if (userInput == "2")
      return "paper";
    if (userInput == "3")
      return "scissors";
    return userInput;
  }

  static string GetComputerHand()
  {
    int randomNumber = new Random().Next(0, 4);
    if (randomNumber == 1)
      return "rock";
    if (randomNumber == 2)
      return "paper";
    else
      return "scissors";

  }




}

// internal class SaveData
// {
//   public int PlayerWins { get; set; }
//   public int ComputerWins { get; set; }

//   public SaveData(int playerWins, int computerWins)
//   {
//     PlayerWins = playerWins;
//     ComputerWins = computerWins;
//   }






























