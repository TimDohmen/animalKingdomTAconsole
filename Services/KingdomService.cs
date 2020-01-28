using animalKingdom.Models;

namespace animalKingdom.Services
{
  public class KingdomService
  {
    private Kingdom _king { get; set; }

    public KingdomService()
    {
      _king = new Kingdom();
    }

    public void changeNode(int index)
    {
      _king.currentNode = _king.currentNode.Children[index];
    }
    public void PreviousNode()
    {
      _king.currentNode = _king.currentNode.Parent;
    }
    public void PrintKingdoms()
    {
      for (int i = 0; i < _king.currentNode.Children.Count; i++)
      {
        Node n = _king.currentNode.Children[i];
        System.Console.WriteLine(n.Name);
      }
    }
  }
}