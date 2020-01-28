using System;
using System.Threading;
using animalKingdom.Services;

namespace animalKingdom.Controllers
{
  public class KingdomController
  {
    private KingdomService ks = new KingdomService();

    public void Run()
    {
      Console.Clear();
      Console.WriteLine("Welcome to the Animalia Kingdom");
      while (true)
      {
        ks.PrintKingdoms();
        Print();
        GetUserInput();
      }
    }
    public void GetUserInput()
    {
      Console.WriteLine("Enter a number to visit that kingdom or p to return to previous");
      string input = Console.ReadLine();
      switch (input.ToLower())
      {
        case "q":
        case "quit":
          Environment.Exit(0);
          break;
        case "r":
          Console.Clear();
          ks.Reset();
          break;
        case "p":
        case "prev":
          Console.Clear();
          ks.PreviousNode();
          break;
        default:
          if (int.TryParse(input, out int num))
          {
            System.Console.Write("Loading");
            for (int i = 0; i < 3; i++)
            {
              Console.Write(".");
              Thread.Sleep(200);
            }
            Console.Clear();
            ks.changeNode(num - 1);
          }
          else
          {
            Console.WriteLine("Invalid selection");
          }
          break;
      }
    }

    //NOTE this should print your messages for the game.
    private void Print()
    {
      foreach (string message in ks.Messages)
      {
        System.Console.WriteLine(message);
      }
      ks.Messages.Clear();
    }

  }
}