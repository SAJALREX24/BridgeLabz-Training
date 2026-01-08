using System;

class LibraryBook
{
    public int bookCode;
    public string bookTitle;
    public string writer;
    public string category;
    public bool isAvailable;
    public LibraryBook next;
    public LibraryBook previous;
}

class LibrarySystem
{
    LibraryBook first;
    int totalBooks = 0;

    public void InsertBook()
    {
        LibraryBook book = new LibraryBook();

        Console.Write("Book Code: ");
        book.bookCode = int.Parse(Console.ReadLine());

        Console.Write("Title: ");
        book.bookTitle = Console.ReadLine();

        Console.Write("Author: ");
        book.writer = Console.ReadLine();

        Console.Write("Category: ");
        book.category = Console.ReadLine();

        book.isAvailable = true;

        book.next = first;
        book.previous = null;

        if (first != null)
            first.previous = book;

        first = book;
        totalBooks++;

        Console.WriteLine("Book Inserted");
    }

    public void DeleteBook()
    {
        Console.Write("Book Code: ");
        int code = int.Parse(Console.ReadLine());

        LibraryBook temp = first;

        while (temp != null && temp.bookCode != code)
            temp = temp.next;

        if (temp == null)
        {
            Console.WriteLine("Book Not Found");
            return;
        }

        if (temp.previous != null)
            temp.previous.next = temp.next;
        else
            first = temp.next;

        if (temp.next != null)
            temp.next.previous = temp.previous;

        totalBooks--;
        Console.WriteLine("Book Deleted");
    }

    public void ToggleAvailability()
    {
        Console.Write("Book Code: ");
        int code = int.Parse(Console.ReadLine());

        LibraryBook temp = first;

        while (temp != null)
        {
            if (temp.bookCode == code)
            {
                temp.isAvailable = !temp.isAvailable;
                Console.WriteLine("Availability Changed");
                return;
            }
            temp = temp.next;
        }
    }

    public void Search()
    {
        Console.Write("Enter Title or Author: ");
        string input = Console.ReadLine();

        LibraryBook temp = first;

        while (temp != null)
        {
            if (temp.bookTitle == input || temp.writer == input)
            {
                Console.WriteLine(temp.bookTitle + " by " + temp.writer);
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("No Book Found");
    }

    public void ShowForward()
    {
        LibraryBook temp = first;

        while (temp != null)
        {
            Console.WriteLine(
                temp.bookTitle +
                " | Available: " +
                temp.isAvailable);

            temp = temp.next;
        }
    }

    public void ShowReverse()
    {
        LibraryBook temp = first;

        while (temp.next != null)
            temp = temp.next;

        while (temp != null)
        {
            Console.WriteLine(temp.bookTitle);
            temp = temp.previous;
        }
    }

    public void ShowCount()
    {
        Console.WriteLine("Total Books: " + totalBooks);
    }
}

class Program
{
    static void Main()
    {
        LibrarySystem lib = new LibrarySystem();
        int choice;

        do
        {
            Console.WriteLine("\n--- Library Panel ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. Update Availability");
            Console.WriteLine("5. Display Forward");
            Console.WriteLine("6. Display Reverse");
            Console.WriteLine("7. Count Books");
            Console.WriteLine("8. Exit");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: lib.InsertBook(); break;
                case 2: lib.DeleteBook(); break;
                case 3: lib.Search(); break;
                case 4: lib.ToggleAvailability(); break;
                case 5: lib.ShowForward(); break;
                case 6: lib.ShowReverse(); break;
                case 7: lib.ShowCount(); break;
            }

        } while (choice != 8);
    }
}
