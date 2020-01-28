using System.Collections.Generic;
using animalKingdom.Models;

namespace animalKingdom.Services
{
  public class KingdomService
  {
    private Kingdom _king { get; set; }
    public List<string> Messages { get; set; } = new List<string>();
    public KingdomService()
    {
      _king = new Kingdom();
    }

    public void changeNode(int index)
    {
      if (index < 0 || index > _king.currentNode.Children.Count)
      {
        Messages.Add("Invalid Number");
        return;
      }
      _king.currentNode = _king.currentNode.Children[index];
    }
    public void PreviousNode()
    {
      _king.currentNode = _king.currentNode.Parent;
    }
    public void PrintKingdoms()
    {
      string template = "";
      if (_king.currentNode.Children.Count == 0)
      {
        template = "No further animalia known.";
      }
      else
      {
        for (int i = 0; i < _king.currentNode.Children.Count; i++)
        {
          Node n = _king.currentNode.Children[i];
          template += $"{i + 1}. {n.Name} \n";
          // System.Console.WriteLine(n.Name);
        }
      }
      Messages.Add(template);
    }
    public void Reset()
    {
      _king = new Kingdom();
    }
  }
}