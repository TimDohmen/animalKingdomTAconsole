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
        GetUserInput();
        Print();
      }
    }
    public void GetUserInput()
    {
      Console.WriteLine("Enter a number to visit that kingdom ");
      string input = Console.ReadLine();
      switch (input)
      {
        case "q":
        case "quit":
          ks.Quit();
          break;
        case "r":
          Console.Clear();
          ks.Reset();
          break;

        default:
          if (int.TryParse(input, out int num))
          {
            System.Console.Write("Loading");
            for (int i = 0; i < 6; i++)
            {
              Console.Write(".");
              Thread.Sleep(500);
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