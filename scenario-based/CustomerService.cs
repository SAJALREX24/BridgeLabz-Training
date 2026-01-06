/* Customer Service Call Log Manager 
Scenario: Telecom company tracking call logs. Requirements: 
● Store logs in a Array of CallLogs. 
● Each log contains PhoneNumber, Message, Timestamp.
● Filter logs by time range, search by keywords in message (string.Contains).
● Methods: AddCallLog(), SearchByKeyword(), FilterByTime().
 */
 
 
using System;


class CallRecord
{
    
    public string ContactNumber;

 
    public string CallMessage;

    
    public string CallTime;

   
    public CallRecord(string contactNumber, string callMessage, string callTime)
    {
        ContactNumber = contactNumber;
        CallMessage = callMessage;
        CallTime = callTime;
    }
}


class CallRecordManager
{
    
    private CallRecord[] callRecords;

   
    private int recordCount;

   
    public CallRecordManager(int capacity)
    {
        callRecords = new CallRecord[capacity];
        recordCount = 0;
    }

    // Adds a new call record
    public void AddCallRecord(CallRecord record)
    {
        if (recordCount < callRecords.Length)
        {
            callRecords[recordCount] = record;
            recordCount++;
        }
        else
        {
            Console.WriteLine("Call log storage is full.");
        }
    }

    // Searches call records by keyword in message
    public void SearchByKeyword(string searchText)
    {
        Console.WriteLine("- Search Results -");

        for (int index = 0; index < recordCount; index++)
        {
            if (callRecords[index].CallMessage.Contains(searchText))
            {
                DisplayRecord(callRecords[index]);
            }
        }
    }

    // Filters call records based on time range
    public void FilterByTime(string startTime, string endTime)
    {
        Console.WriteLine("- Filtered Call Logs -");

        for (int index = 0; index < recordCount; index++)
        {
            if (callRecords[index].CallTime.CompareTo(startTime) >= 0 &&
                callRecords[index].CallTime.CompareTo(endTime) <= 0)
            {
                DisplayRecord(callRecords[index]);
            }
        }
    }

    // Displays a single call record
    private void DisplayRecord(CallRecord record)
    {
        Console.WriteLine(
            "Phone: " + record.ContactNumber +
            ", Message: " + record.CallMessage +
            ", Time: " + record.CallTime
        );
    }
}


class Program
{
    static void Main()
    {
       
        Console.Write("Enter number of call logs: ");
        int totalLogs = int.Parse(Console.ReadLine());

       
        CallRecordManager recordManager = new CallRecordManager(totalLogs);

       
        for (int i = 0; i < totalLogs; i++)
        {
            Console.WriteLine("Enter details for Call Log " + (i + 1));

            Console.Write("Phone Number: ");
            string number = Console.ReadLine();

            Console.Write("Message");
            string message = Console.ReadLine();

            Console.Write("Time (HH:MM):");
            string time = Console.ReadLine();

            // Add record to manager
            recordManager.AddCallRecord(
                new CallRecord(number, message, time)
            );
        }

        // Keyword search
        Console.Write("\nEnter keyword to search: ");
        string keyword = Console.ReadLine();
        recordManager.SearchByKeyword(keyword);

        // Time-based filtering
        Console.Write("\nEnter start time (HH:MM): ");
        string startTime = Console.ReadLine();

        Console.Write("Enter end time (HH:MM): ");
        string endTime = Console.ReadLine();

        recordManager.FilterByTime(startTime, endTime);
    }
}

