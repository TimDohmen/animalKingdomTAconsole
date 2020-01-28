namespace animalKingdom.Models
{
  public class Kingdom
  {
    public Node currentNode { get; set; }

    public void Setup()
    {
      Node start = new Node("Classifications of Animals");

      Node vertebrate = new Node("Vertebrates");


      Node warm = new Node("Warm-Blooded");

      Node mammal = new Node("Mammals");
      Node bird = new Node("Birds");


      Node cold = new Node("Cold-Booded");

      Node fish = new Node("Fish");
      Node reptile = new Node("Reptiles");
      Node amphib = new Node("Amphibians");



      Node invertebrate = new Node("Invertebrates");


      Node legs = new Node("With Jointed Legs");

      Node threelegs = new Node("With 3 pairs of legs");
      Node morelegs = new Node("With more than 3 pairs of legs");


      Node nolegs = new Node("Without Legs");

      Node worm = new Node("Worm Like");
      Node notworm = new Node("Not-Worm Like");



    }
  }
}