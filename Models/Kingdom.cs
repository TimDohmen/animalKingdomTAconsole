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


      Node bear = new Node("Bear");
      Node tiger = new Node("Tiger");
      Node whale = new Node("Whale");

      Node ostrich = new Node("Ostrich");
      Node peacock = new Node("Peacock");
      Node eagle = new Node("Eagle");

      Node salmon = new Node("Salmon");
      Node goldfish = new Node("Goldfish");
      Node guppy = new Node("Guppy");

      Node turtle = new Node("Turtle");
      Node croc = new Node("Crocodile");
      Node snek = new Node("Snake");

      Node frog = new Node("Frog");
      Node toad = new Node("Toad");
      Node newt = new Node("Newt");

      Node ant = new Node("Ant");
      Node roach = new Node("Cockroach");
      Node bug = new Node("Ladybug");

      Node scorp = new Node("Scorpion");
      Node spider = new Node("Spider");
      Node milli = new Node("Millipede");

      Node earth = new Node("Earthworm");
      Node leech = new Node("Leech");

      Node fluke = new Node("Fluke Worm");
      Node tape = new Node("TapeWorm");

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
      mammal.AddNode(bear);
      mammal.AddNode(tiger);
      mammal.AddNode(whale);
      whale.Parent = mammal;
      bear.Parent = mammal;
      tiger.Parent = mammal;
      bird.AddNode(ostrich);
      bird.AddNode(peacock);
      bird.AddNode(eagle);
      ostrich.Parent = bird;
      peacock.Parent = bird;
      eagle.Parent = bird;

      cold.Parent = vertebrate;
      cold.AddNode(fish);
      cold.AddNode(reptile);
      cold.AddNode(amphib);
      fish.Parent = cold;
      reptile.Parent = cold;
      amphib.Parent = cold;
      fish.AddNode(salmon);
      fish.AddNode(goldfish);
      fish.AddNode(guppy);
      salmon.Parent = fish;
      goldfish.Parent = fish;
      guppy.Parent = fish;
      reptile.AddNode(turtle);
      reptile.AddNode(croc);
      reptile.AddNode(snek);
      turtle.Parent = reptile;
      croc.Parent = reptile;
      snek.Parent = reptile;
      amphib.AddNode(frog);
      amphib.AddNode(toad);
      amphib.AddNode(newt);
      frog.Parent = amphib;
      toad.Parent = amphib;
      newt.Parent = amphib;

      invertebrate.Parent = start;
      invertebrate.AddNode(legs);
      invertebrate.AddNode(nolegs);
      legs.Parent = invertebrate;
      legs.AddNode(threelegs);
      legs.AddNode(morelegs);
      threelegs.Parent = legs;
      morelegs.Parent = legs;
      threelegs.AddNode(ant);
      threelegs.AddNode(roach);
      threelegs.AddNode(bug);
      ant.Parent = threelegs;
      roach.Parent = threelegs;
      bug.Parent = threelegs;
      morelegs.AddNode(scorp);
      morelegs.AddNode(spider);
      morelegs.AddNode(milli);
      scorp.Parent = morelegs;
      spider.Parent = morelegs;
      milli.Parent = morelegs;

      nolegs.Parent = invertebrate;
      nolegs.AddNode(worm);
      nolegs.AddNode(notworm);
      worm.Parent = nolegs;
      notworm.Parent = nolegs;
      worm.AddNode(earth);
      worm.AddNode(leech);
      earth.Parent = worm;
      leech.Parent = worm;
      notworm.AddNode(fluke);
      notworm.AddNode(tape);
      fluke.Parent = notworm;
      tape.Parent = notworm;
    }
    public Kingdom()
    {
      Setup();
    }
  }
}