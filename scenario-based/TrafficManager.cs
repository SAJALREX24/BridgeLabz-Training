
using System;

// ABSTRACTION
interface ITrafficManager
{
    void AddToQueue();
    void EnterRoundabout();
    void ExitRoundabout();
    void DisplayState();
}

// B C
class Vehicle
{
    protected string number;

    public Vehicle(string vehicleNumber)
    {
        number = vehicleNumber;
    }

    public virtual void Display()
    {
        Console.Write(number + " ");
    }

    public string GetNumber()
    {
        return number;
    }
}

// INHERITANCE
class Car : Vehicle
{
    public Car(string number) : base(number) { }

    public override void Display()
    {
        Console.Write("[Car: " + number + "] ");
    }
}

// NODE (CIRCULAR LINKED LIST)
class VehicleNode
{
    public Vehicle VehicleData;
    public VehicleNode Next;

    public VehicleNode(Vehicle vehicle)
    {
        VehicleData = vehicle;
        Next = null;
    }
}

// CIRCULAR LINKED LIST (ROUNDABOUT)
class Roundabout
{
    private VehicleNode tail;

    public void AddVehicle(Vehicle vehicle)
    {
        VehicleNode node = new VehicleNode(vehicle);

        if (tail == null)
        {
            tail = node;
            tail.Next = tail;
            return;
        }

        node.Next = tail.Next;
        tail.Next = node;
        tail = node;
    }

    public void RemoveVehicle()
    {
        if (tail == null)
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        VehicleNode head = tail.Next;

        if (head == tail)
        {
            Console.WriteLine("Vehicle exited: " + head.VehicleData.GetNumber());
            tail = null;
            return;
        }

        Console.WriteLine("Vehicle exited: " + head.VehicleData.GetNumber());
        tail.Next = head.Next;
    }

    public void Display()
    {
        if (tail == null)
        {
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        VehicleNode current = tail.Next;
        Console.Write("Roundabout: ");

        do
        {
            current.VehicleData.Display();
            current = current.Next;
        }
        while (current != tail.Next);

        Console.WriteLine();
    }
}

// QUEUE
class VehicleQueue
{
    private Vehicle[] vehicles;
    private int frontIndex, rearIndex, count;

    public VehicleQueue(int capacity)
    {
        vehicles = new Vehicle[capacity];
        frontIndex = 0;
        rearIndex = -1;
        count = 0;
    }

    public void Enqueue(Vehicle vehicle)
    {
        if (count == vehicles.Length)
        {
            Console.WriteLine("Queue Overflow!");
            return;
        }

        rearIndex++;
        vehicles[rearIndex] = vehicle;
        count++;

        Console.WriteLine("Vehicle added to waiting queue.");
    }

    public Vehicle Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue Underflow!");
            return null;
        }

        Vehicle vehicle = vehicles[frontIndex];
        frontIndex++;
        count--;
        return vehicle;
    }

    public void Display()
    {
        if (count == 0)
        {
            Console.WriteLine("Waiting queue empty.");
            return;
        }

        Console.Write("Waiting Queue: ");
        for (int i = frontIndex; i <= rearIndex; i++)
        {
            vehicles[i].Display();
        }
        Console.WriteLine();
    }

    public bool IsEmpty()
    {
        return count == 0;
    }
}

// TRAFFIC MANAGER
class TrafficManager : ITrafficManager
{
    private Roundabout roundabout;
    private VehicleQueue waitingQueue;

    public TrafficManager()
    {
        roundabout = new Roundabout();
        waitingQueue = new VehicleQueue(5);
    }

    public void AddToQueue()
    {
        Console.Write("Enter Vehicle Number: ");
        string number = Console.ReadLine();

        Vehicle vehicle = new Car(number);
        waitingQueue.Enqueue(vehicle);
    }

    public void EnterRoundabout()
    {
        if (!waitingQueue.IsEmpty())
        {
            Vehicle vehicle = waitingQueue.Dequeue();
            roundabout.AddVehicle(vehicle);
            Console.WriteLine("Vehicle entered roundabout.");
        }
        else
        {
            Console.WriteLine("No vehicles in queue.");
        }
    }

    public void ExitRoundabout()
    {
        roundabout.RemoveVehicle();
    }

    public void DisplayState()
    {
        roundabout.Display();
        waitingQueue.Display();
    }
}

// MENU-DRIVEN MAIN
class Program
{
    static void Main()
    {
        ITrafficManager manager = new TrafficManager();
        int choice = 0;

        do
        {
            Console.WriteLine("\n--- Traffic Manager ---");
            Console.WriteLine("1. Add Vehicle to Queue");
            Console.WriteLine("2. Enter Roundabout");
            Console.WriteLine("3. Exit Roundabout");
            Console.WriteLine("4. Display State");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    manager.AddToQueue();
                    break;
                case 2:
                    manager.EnterRoundabout();
                    break;
                case 3:
                    manager.ExitRoundabout();
                    break;
                case 4:
                    manager.DisplayState();
                    break;
                case 5:
                    Console.WriteLine("Exiting system.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}
