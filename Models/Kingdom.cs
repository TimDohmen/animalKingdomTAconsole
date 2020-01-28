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

      currentNode = start;
      start.Parent = start;
      start.AddNode(vertebrate);
      start.AddNode(invertebrate);

      vertebrate.Parent = start;
      vertebrate.AddNode(warm);
      vertebrate.AddNode(cold);
      warm.Parent = vertebrate;
      warm.AddNode(mammal);
      warm.AddNode(bird);
      bird.Parent = warm;
      mammal.Parent = warm;
      cold.Parent = vertebrate;
      cold.AddNode(fish);
      cold.AddNode(reptile);
      cold.AddNode(amphib);
      fish.Parent = cold;
      reptile.Parent = cold;
      amphib.Parent = cold;

      invertebrate.Parent = start;
      invertebrate.AddNode(legs);
      invertebrate.AddNode(nolegs);
      legs.Parent = invertebrate;
      legs.AddNode(threelegs);
      legs.AddNode(morelegs);
      threelegs.Parent = legs;
      morelegs.Parent = legs;

      nolegs.Parent = invertebrate;
      nolegs.AddNode(worm);
      nolegs.AddNode(notworm);
      worm.Parent = nolegs;
      notworm.Parent = nolegs;
    }
    public Kingdom()
    {
      Setup();
    }
  }
}