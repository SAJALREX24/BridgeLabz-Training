using System;
interface IMovieUtility
{
    void InsertMovie(string name, string showTime);
    bool FindMovie(string searchText);
    void ShowAllMovies();
}

class DataHolder
{
    private string[] movieNames;
    private string[] movieSchedules;

    public string[] MovieNames
    {
        get { return movieNames; }
        set { movieNames = value; }
    }

    public string[] MovieSchedules
    {
        get { return movieSchedules; }
        set { movieSchedules = value; }
    }
}



class MovieUtility : IMovieUtility
{
    DataHolder data = new DataHolder();

    public void InsertMovie(string name, string showTime)
    {
        Console.Write("Enter total number of movies: ");
        int count = Convert.ToInt32(Console.ReadLine());

        string[] names = new string[count];
        string[] schedules = new string[count];

        for (int index = 0; index < count; index++)
        {
            Console.Write("Enter movie name: ");
            names[index] = Console.ReadLine();

            Console.Write("Enter show timing: ");
            schedules[index] = Console.ReadLine();
        }

        data.MovieNames = names;
        data.MovieSchedules = schedules;

        Console.WriteLine("Movie list saved successfully!");
    }

    public bool FindMovie(string searchText)
    {
        if (data.MovieNames == null)
            return false;

        foreach (string movie in data.MovieNames)
        {
            if (movie.Contains(searchText))
            {
                return true;
            }
        }
        return false;
    }

    public void ShowAllMovies()
    {
        if (data.MovieNames == null || data.MovieSchedules == null)
        {
            Console.WriteLine("Movie list is empty.");
            return;
        }

        for (int i = 0; i < data.MovieNames.Length; i++)
        {
            Console.WriteLine(
                "Movie: " + data.MovieNames[i] +
                " | Index: " + i +
                " | Time: " + data.MovieSchedules[i]
            );
        }
    }
}








class UserMenu
{
   

    public void StartMenu()
    {
		IMovieUtility movieUtility = new MovieUtility();
        int option = 0;

        while (option != 4)
        {
            Console.WriteLine("\n--- Movie Menu ---");
            Console.WriteLine("1. Add Movies");
            Console.WriteLine("2. Search Movie");
            Console.WriteLine("3. View All Movies");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    movieUtility.InsertMovie("", "");
                    break;

                case 2:
                    Console.Write("Enter movie keyword: ");
                    string keyword = Console.ReadLine();

                    Console.WriteLine(
                        movieUtility.FindMovie(keyword)
                        ? "Movie Available"
                        : "Movie Not Found"
                    );
                    break;

                case 3:
                    movieUtility.ShowAllMovies();
                    break;

                case 4:
                    Console.WriteLine("Application closed.");
                    break;

                default:
                    Console.WriteLine("Please select a valid option.");
                    break;
            }
        }
    }
}







class Program
{
    static void Main(string[] args)
    {
        UserMenu menu = new UserMenu();
        menu.StartMenu();
    }
}
