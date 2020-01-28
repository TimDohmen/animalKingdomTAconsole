using System.Collections.Generic;

namespace animalKingdom.Models
{
  public class Node
  {
    public Node Parent { get; set; }
    public string Name { get; set; }
    public List<Node> Children { get; set; } = new List<Node>();
    public Node(string name)
    {
      Name = name;
    }
    public void AddNode(Node child)
    {
      Children.Add(child);
    }
  }
}