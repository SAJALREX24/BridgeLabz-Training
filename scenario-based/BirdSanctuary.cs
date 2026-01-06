
/*

Goal: Design a Bird Sanctuary system using Inheritance and Polymorphism.
Scenario: EcoWing Wildlife Conservation Center needs to track birds.● Attributes: defined in base class Bird.
● Interfaces: IFlyable (method Fly()), ISwimmable (method Swim()).
● Derived Classes: Eagle, Sparrow (implement IFlyable), Duck, Penguin (implement
ISwimmable), Seagull (implements both).
●Use Array Concept
● Polymorphism: Iterate through list, check interface type (is IFlyable), and call
methods.

*/
using System;

// Interface
interface IFlyable
{
    void Fly();
}

// Interface 
interface ISwimmable
{
    void Swim();
}

// Base class 
class Bird
{
    // Stores bird's name
    public string BirdName;

    // Constructor 
    public Bird(string birdName)
    {
        BirdName = birdName;
    }

    // Displays bird information
    public void Display()
    {
        Console.WriteLine("Bird: " + BirdName);
    }
}

// Eagle can fly
class Eagle : Bird, IFlyable
{
    public Eagle(string birdName) : base(birdName) { }

    public void Fly()
    {
        Console.WriteLine(BirdName + " is flying high.");
    }
}

// Sparrow can fly
class Sparrow : Bird, IFlyable
{
    public Sparrow(string birdName) : base(birdName) { }

    public void Fly()
    {
        Console.WriteLine(BirdName + " is flying.");
    }
}

// Duck can swim
class Duck : Bird, ISwimmable
{
    public Duck(string birdName) : base(birdName) { }

    public void Swim()
    {
        Console.WriteLine(BirdName + " is swimming.");
    }
}

// Penguin can swim
class Penguin : Bird, ISwimmable
{
    public Penguin(string birdName) : base(birdName) { }

    public void Swim()
    {
        Console.WriteLine(BirdName + " is swimming fast.");
    }
}


class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string birdName) : base(birdName) { }

    public void Fly()
    {
        Console.WriteLine(BirdName + " is flying near sea.");
    }

    public void Swim()
    {
        Console.WriteLine(BirdName + " is swimming in sea.");
    }
}

// Main class
class Program
{
    static void Main()
    {
        
        Bird[] birdList = new Bird[5];

       
        birdList[0] = new Eagle("Eagle");
        birdList[1] = new Sparrow("Sparrow");
        birdList[2] = new Duck("Duck");
        birdList[3] = new Penguin("Penguin");
        birdList[4] = new Seagull("Seagull");

       
        foreach (Bird currentBird in birdList)
        {
            
            currentBird.Display();

            // Check and execute flying behavior
            if (currentBird is IFlyable)
            {
                ((IFlyable)currentBird).Fly();
            }

            // Check and execute swimming behavior
            if (currentBird is ISwimmable)
            {
                ((ISwimmable)currentBird).Swim();
            }

          
            Console.WriteLine();
        }
    }
}
