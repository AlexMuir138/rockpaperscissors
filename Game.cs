using System;
using System.Collections.Generic;
using Intro.Utils;

namespace Intro 
{
  class Game 
  {
    private bool _playing = true;
    private string _computerChoice = "";
    ScreenPrinter sp = new ScreenPrinter();
    public void Start()
    {
    sp.print(@"
    Shall we play a game?
    "
    );
    PlayGame();
    }
  public void PlayGame()
  {
      var random = new Random();
      var list = new List<string>{"rock", "paper", "scissors"};
      int index = random.Next(list.Count);
      _computerChoice = list[index];
    
    while(_playing)
    {
      // Console.Clear();
      sp.print(@"
      Choose Wisely
    Rock  Paper  Scissors
      ");
      Console.Write("Make Your Move - ");
      string userInput = Console.ReadLine();

      if(userInput == "q")
      {
        _playing = false;
        sp.print("Fine, ya quitter!");
        return;
      }

      if(userInput =="rock")
      {
        if((_computerChoice) == "rock")
        {
          Console.WriteLine("Computer chooses rock");
          Console.WriteLine("It's a tie!");
        }
        else if (_computerChoice == "paper")
        {
          Console.WriteLine("Computer chooses paper");
          Console.WriteLine("You lose sucka!");
        }
        else if (_computerChoice == "scissors")
        {
          Console.WriteLine("Computer chooses scissors");
          Console.WriteLine("You win and I hate you!");
        }
      
  }
      if(userInput =="paper")
      {
        if((_computerChoice) == "paper")
        {
          Console.WriteLine("Computer chooses paper");
          Console.WriteLine("It's a tie!");
        }
        else if (_computerChoice == "scissors")
        {
          Console.WriteLine("Computer chooses scissors");
          Console.WriteLine("You lose sucka!");
        }
        else if (_computerChoice == "rock")
        {
          Console.WriteLine("Computer chooses rock");
          Console.WriteLine("You win and I hate you!");
        }
      
  }
      if(userInput =="scissors")
      {
        if((_computerChoice) == "scissors")
        {
          Console.WriteLine("Computer chooses scissors");
          Console.WriteLine("It's a tie!");
        }
        else if (_computerChoice == "rock")
        {
          Console.WriteLine("Computer chooses rock");
          Console.WriteLine("You lose sucka!");
        }
        else if (_computerChoice == "paper")
        {
          Console.WriteLine("Computer chooses paper");
          Console.WriteLine("You win and I hate you!");
        }
      
  }
  Console.WriteLine("Play again fool? Y/N ");
    string userChoice = Console.ReadLine();
    if(userChoice == "Y")
    {
      PlayGame();
    }
    else if (userChoice == "N")
    {
      _playing = false;
        sp.print("Fine, ya quitter!");
    }

  }
  }
  }
}