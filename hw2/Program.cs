using System.Diagnostics;
using ikoLite.Services.Booking;

var rest = new BookingService();

//Thread thread1 = new(new ThreadStart(rest.AutoCleanBooks));
//thread1.Start();

while (true)
{
    Console.WriteLine("Welcome! Would you like to book a table? \n" +
        "1 - add book sms(async)\n" +
        "2 - add book phone call(sync)\n" +
        "3 - remove book sms(async)\n" +
        "4 - remove book phone call(sync)");

    if(!int.TryParse(Console.ReadLine(), out var choice) && choice is not(1 or 2 or 3 or 4))
    {
        Console.WriteLine("Please, enter 1,2,3 or 4");
        continue;
    }

    Stopwatch stopwatch = new();
    stopwatch.Start();

    //todo add user enter for all methods
    if (choice == 1)
        rest.BookFreeTableAsync(1);

    if (choice == 2)
        rest.BookFreeTable(1);

    if (choice == 3)
        rest.RemoveBookedTable(1);

    if (choice == 4)
        rest.RemoveBookedTableAsync(1);

    Console.WriteLine("Thank's for booking");
    stopwatch.Stop();
    TimeSpan timeSpan = stopwatch.Elapsed;
    Console.WriteLine($"{timeSpan.Seconds:00}:{timeSpan.Milliseconds}:{timeSpan.Nanoseconds}");
}
