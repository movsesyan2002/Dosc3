// Task 7: Ticket Booking System
// Task: Create a MovieTicket class with:
// MovieName, SeatNumber, IsBooked.
// A method BookTicket() that marks it as booked.
// In Main(), create 5 seats, allow the user to book one, and prevent double booking.
// Show all available seats before booking.

class MovieTicket
{
    public string MovieName;
    public int SeatNumber;
    public bool IsBooked;


    public MovieTicket (string movieName, int seatNumber)
    {
        this.MovieName = movieName;
        this.SeatNumber = seatNumber;
        this.IsBooked = false;
    }

    public void BookTicket() 
    {
        if (this.IsBooked == false)
        {
            this.IsBooked = true;
        }

    }
}



class Program
{
    static void Main(string[] args)
    {
        MovieTicket ticket1 = new MovieTicket("Titanic",5);
        MovieTicket ticket2 = new MovieTicket("Inception",4);
        MovieTicket ticket3 = new MovieTicket("The Dark Knight",3);
        MovieTicket ticket4 = new MovieTicket("The Godfather",2);
        MovieTicket ticket5 = new MovieTicket("Avatar",1);
        MovieTicket[] movieTickets = new MovieTicket[5]{ticket1, ticket2, ticket3, ticket4, ticket5};

        while (true) 
        {
            Console.WriteLine("This is our avaible filmes");
            foreach (MovieTicket item in movieTickets)
            {
                if (item.IsBooked == false)
                Console.WriteLine($"{item.MovieName},{item.SeatNumber}");
            } 

            Console.WriteLine("Which seat do you want enter seat number for exit 0");
            int.TryParse(Console.ReadLine(), out int number);
            if (number == 0)
            {
                Console.WriteLine("exiteed...");
                return;
            }
            else
            {
                for (int i = 0; i < movieTickets.Length; i++)
                {
                    if (movieTickets[i].SeatNumber == number) 
                    {
                        if (movieTickets[i].IsBooked == true) 
                        {
                             Console.WriteLine("the ticket is booked");
                             return;
                        }
                        movieTickets[i].BookTicket();
                        break;
                    }
                }
            }
        }
    }
}
