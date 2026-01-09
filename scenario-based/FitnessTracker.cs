/*

"FitTrack – Fitness Tracker"
● Classes: UserProfile, Workout.
● Interface: ITrackable.
● Types: CardioWorkout, StrengthWorkout.


*/

using System;

class Workout
{
    protected int duration;
    protected int calorieBurned;
    protected int progress;

    public Workout(int duration, int calorieBurned, int progress)
    {
        this.duration = duration;
        this.calorieBurned = calorieBurned;
        this.progress = progress;
    }
}

interface ITrackable
{
    void TrackProgress();
    void TrackCalories();
}

class CardioWorkout : Workout, ITrackable
{
    private string type;
    private int time;

    public CardioWorkout(int duration, int calorieBurned, int progress, string type, int time)
        : base(duration, calorieBurned, progress)
    {
        this.type = type;
        this.time = time;
    }

    public void TrackProgress()
    {
        Console.WriteLine("Cardio workout progress: " + progress + "% completed");
    }

    public void TrackCalories()
    {
        Console.WriteLine("Energy burned during cardio: " + calorieBurned + " kcal");
    }
}

class StrengthWorkout : Workout, ITrackable
{
    private string type;
    private int time;

    public StrengthWorkout(int duration, int calorieBurned, int progress, string type, int time)
        : base(duration, calorieBurned, progress)
    {
        this.type = type;
        this.time = time;
    }

    public void TrackProgress()
    {
        Console.WriteLine("Strength training progress: " + progress + "% completed");
    }

    public void TrackCalories()
    {
        Console.WriteLine("Energy burned during strength workout: " + calorieBurned + " kcal");
    }
}

class FitnessTracker
{
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("FitTrack Console");
            Console.WriteLine("1 -> Start Cardio Workout");
            Console.WriteLine("2 -> Start Strength Workout");
            Console.WriteLine("3 -> Quit Application");
            Console.Write("Select an option: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter workout duration (minutes): ");
                    int cDuration = int.Parse(Console.ReadLine());

                    Console.Write("Enter calories burned: ");
                    int cCalories = int.Parse(Console.ReadLine());

                    Console.Write("Enter progress percentage: ");
                    int cProgress = int.Parse(Console.ReadLine());

                    Console.Write("Enter cardio workout type: ");
                    string cType = Console.ReadLine();

                    Console.Write("Enter total time spent: ");
                    int cTime = int.Parse(Console.ReadLine());

                    CardioWorkout cardio = new CardioWorkout(
                        cDuration, cCalories, cProgress, cType, cTime
                    );

                    cardio.TrackProgress();
                    cardio.TrackCalories();
                    break;

                case 2:
                    Console.Write("Enter workout duration (minutes): ");
                    int sDuration = int.Parse(Console.ReadLine());

                    Console.Write("Enter calories burned: ");
                    int sCalories = int.Parse(Console.ReadLine());

                    Console.Write("Enter progress percentage: ");
                    int sProgress = int.Parse(Console.ReadLine());

                    Console.Write("Enter strength workout type: ");
                    string sType = Console.ReadLine();

                    Console.Write("Enter total time spent: ");
                    int sTime = int.Parse(Console.ReadLine());

                    StrengthWorkout strength = new StrengthWorkout(
                        sDuration, sCalories, sProgress, sType, sTime
                    );

                    strength.TrackProgress();
                    strength.TrackCalories();
                    break;

                case 3:
                    Console.WriteLine("Thank you for using FitTrack. Stay healthy!");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please choose a valid option.");
                    break;
            }

        } while (choice != 3);
    }
}

