using System;

class FilmNode
{
    public string movieName;
    public string movieDirector;
    public int releaseYear;
    public double imdbScore;
    public FilmNode next;
    public FilmNode previous;
}

class FilmList
{
    FilmNode head;

    public void AddFilm()
    {
        FilmNode film = new FilmNode();

        Console.Write("Movie Name: ");
        film.movieName = Console.ReadLine();

        Console.Write("Director Name: ");
        film.movieDirector = Console.ReadLine();

        Console.Write("Release Year: ");
        film.releaseYear = int.Parse(Console.ReadLine());

        Console.Write("IMDB Rating: ");
        film.imdbScore = double.Parse(Console.ReadLine());

        film.next = head;
        film.previous = null;

        if (head != null)
            head.previous = film;

        head = film;

        Console.WriteLine("Movie Added Successfully");
    }

    public void RemoveFilm()
    {
        Console.Write("Enter Movie Name: ");
        string name = Console.ReadLine();

        FilmNode temp = head;

        while (temp != null && temp.movieName != name)
            temp = temp.next;

        if (temp == null)
        {
            Console.WriteLine("Movie Not Found");
            return;
        }

        if (temp.previous != null)
            temp.previous.next = temp.next;
        else
            head = temp.next;

        if (temp.next != null)
            temp.next.previous = temp.previous;

        Console.WriteLine("Movie Removed");
    }

    public void DisplayMovies()
    {
        FilmNode temp = head;

        if (temp == null)
        {
            Console.WriteLine("No Movies Available");
            return;
        }

        while (temp != null)
        {
            Console.WriteLine(
                temp.movieName +
                " | Rating: " +
                temp.imdbScore);

            temp = temp.next;
        }
    }
}

class Program
{
    static void Main()
    {
        FilmList list = new FilmList();
        int option;

        do
        {
            Console.WriteLine("Movie Menu");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Delete Movie");
            Console.WriteLine("3. Show Movies");
            Console.WriteLine("4. Exit");
            Console.Write("Enter Choice: ");

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: list.AddFilm(); break;
                case 2: list.RemoveFilm(); break;
                case 3: list.DisplayMovies(); break;
            }

        } while (option != 4);
    }
}
