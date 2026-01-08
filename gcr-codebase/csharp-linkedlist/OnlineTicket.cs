using System;

class BookingNode
{
    public int bookingId;
    public string customerName;
    public string showName;
    public int seatNumber;
    public BookingNode next;
}

class TicketBookingSystem
{
    BookingNode first;
    int totalBookings = 0;

    public void BookSeat()
    {
        BookingNode node = new BookingNode();

        Console.Write("Booking ID: ");
        node.bookingId = int.Parse(Console.ReadLine());

        Console.Write("Customer Name: ");
        node.customerName = Console.ReadLine();

        Console.Write("Show Name: ");
        node.showName = Console.ReadLine();

        Console.Write("Seat Number: ");
        node.seatNumber = int.Parse(Console.ReadLine());

        if (first == null)
        {
            first = node;
            node.next = first;
        }
        else
        {
            BookingNode temp = first;
            while (temp.next != first)
                temp = temp.next;

            temp.next = node;
            node.next = first;
        }

        totalBookings++;
        Console.WriteLine("Ticket Booked Successfully");
    }

    public void CancelBooking()
    {
        Console.Write("Enter Booking ID: ");
        int id = int.Parse(Console.ReadLine());

        BookingNode current = first, previous = null;

        if (first == null)
        {
            Console.WriteLine("No Bookings Found");
            return;
        }

        do
        {
            if (current.bookingId == id)
            {
                if (previous != null)
                    previous.next = current.next;
                else
                {
                    BookingNode last = first;
                    while (last.next != first)
                        last = last.next;

                    first = current.next;
                    last.next = first;
                }

                totalBookings--;
                Console.WriteLine("Ticket Cancelled");
                return;
            }

            previous = current;
            current = current.next;

        } while (current != first);

        Console.WriteLine("Booking Not Found");
    }

    public void ShowBookings()
    {
        if (first == null)
        {
            Console.WriteLine("No Tickets Booked");
            return;
        }

        BookingNode temp = first;
        do
        {
            Console.WriteLine(
                "BookingID: " + temp.bookingId +
                " Customer: " + temp.customerName +
                " Show: " + temp.showName +
                " Seat: " + temp.seatNumber);

            temp = temp.next;
        }
        while (temp != first);
    }

    public void ShowBookingCount()
    {
        Console.WriteLine("Total Bookings: " + totalBookings);
    }
}

class Program
{
    static void Main()
    {
        TicketBookingSystem system = new TicketBookingSystem();
        int choice;

        do
        {
            Console.WriteLine("Ticket Booking Menu");
            Console.WriteLine("1. Book Ticket");
            Console.WriteLine("2. Cancel Ticket");
            Console.WriteLine("3. View Bookings");
            Console.WriteLine("4. Count Bookings");
            Console.WriteLine("5. Exit");
            Console.Write("Choose Option: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: system.BookSeat(); break;
                case 2: system.CancelBooking(); break;
                case 3: system.ShowBookings(); break;
                case 4: system.ShowBookingCount(); break;
            }

        } while (choice != 5);
    }
}
