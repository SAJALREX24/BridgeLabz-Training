
using System;

interface IBookManager
{
    void InsertBook(string bookName, string writer);
    void ArrangeBooks();
    void FindBooksByWriter(string writerName);
}

class BookStore
{
    private string[] bookRecords;

    public string[] BookRecords
    {
        get { return bookRecords; }
        set { bookRecords = value; }
    }
}




class BookManager : IBookManager
{
    BookStore store = new BookStore();

    public void InsertBook(string bookName, string writer)
    {
        Console.Write("Enter how many books you want to add: ");
        int total = Convert.ToInt32(Console.ReadLine());

        string[] records = new string[total];

        for (int index = 0; index < total; index++)
        {
            Console.Write("Enter book name: ");
            string name = Console.ReadLine();

            Console.Write("Enter author name: ");
            string authorName = Console.ReadLine();

            records[index] = name + " - " + authorName;
        }

        store.BookRecords = records;
        Console.WriteLine("Book details saved successfully.");
    }

    public void ArrangeBooks()
    {
        if (store.BookRecords == null)
        {
            Console.WriteLine("No book data available for sorting.");
            return;
        }

        Array.Sort(store.BookRecords);
        Console.WriteLine("Books arranged alphabetically:");

        foreach (string item in store.BookRecords)
        {
            Console.WriteLine(item);
        }
    }

    public void FindBooksByWriter(string writerName)
    {
        if (store.BookRecords == null)
        {
            Console.WriteLine("No books available to search.");
            return;
        }

        bool isFound = false;

        foreach (string record in store.BookRecords)
        {
            string[] details = record.Split('-');
            string author = details[1].Trim();

            if (author.Contains(writerName))
            {
                Console.WriteLine("Match Found: " + record);
                isFound = true;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No books found for the given author.");
        }
    }
}




class BookMenu
{
    IBookManager manager = new BookManager();

    public void ShowMenu()
    {
        int option = 0;

        while (option != 4)
        {
            Console.WriteLine("\n--- BookShelf Manager ---");
            Console.WriteLine("1. Add Book Records");
            Console.WriteLine("2. Sort Books");
            Console.WriteLine("3. Search Books by Author");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    manager.InsertBook("", "");
                    break;

                case 2:
                    manager.ArrangeBooks();
                    break;

                case 3:
                    Console.Write("Enter author keyword: ");
                    string searchKey = Console.ReadLine();
                    manager.FindBooksByWriter(searchKey);
                    break;

                case 4:
                    Console.WriteLine("Program terminated.");
                    break;

                default:
                    Console.WriteLine("Please enter a valid choice.");
                    break;
            }
        }
    }
}





class Program
{
    static void Main(string[] args)
    {
        BookMenu menu = new BookMenu();
        menu.ShowMenu();
    }
}
