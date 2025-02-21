
// Task 9: Car Rental System
// Task: Create a Car class with:
// Model, Year, IsRented.
// Methods RentCar() and ReturnCar().
// In Main(), create a fleet of 5 cars, let users rent and return cars.
// Prevent renting an already rented car.


class Car 
{
    private string model;
    private int year;
    public bool Isrented;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }   
    }

    
    public Car(string model, int year)
    {
        this.model = model;
        this.year = year;
        this.Isrented = false;
    }

    public void RentCar() 
    {
        if (this.Isrented == false) 
        {
            this.Isrented = true;
        }

        else 
        {
            Console.WriteLine("The car is rented");
        }
    }


    public void ReturnCar() 
    {
        if (this.Isrented == true) 
        {
            this.Isrented = false;
        }

        else 
        {
            Console.WriteLine("The car is returned");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Car car= new Car("Ford",2020);
        Car car2= new Car("Bmw",2018);
        Car car3= new Car("Mercedes",2019);
        Car car4= new Car("Kia",2024);
        Car car5= new Car("Audi",2022);
        Car[] cars = new Car[] { car, car2, car3, car4, car5};


        while (true)
        {
            Console.WriteLine("What are you want Rent car or Return");
            Console.WriteLine("For exit enter 0");
            string? choice = Console.ReadLine();


            if (string.Compare(choice,"rent") == 0)
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i].Isrented == false)
                    {
                        Console.WriteLine($"The car model is {cars[i].Model} and year is {cars[i].Year}");
                    }
                }

                Console.WriteLine("Which you want?");
                string? carname = Console.ReadLine();
                
                for (int i = 0; i < cars.Length; i++)
                {
                    if (string.Compare(cars[i].Model,carname) == 0)
                    {
                        cars[i].RentCar();
                        break;
                    }

                }
            }

            else if (string.Compare(choice,"return") == 0)
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i].Isrented == true)
                    {
                        Console.WriteLine($"The car model is {cars[i].Model} and year is {cars[i].Year}");
                    }
                }

                Console.WriteLine("Which car you want return?");
                string? carname = Console.ReadLine();
                
                for (int i = 0; i < cars.Length; i++)
                {
                    if (string.Compare(cars[i].Model,carname) == 0)
                    {
                        cars[i].ReturnCar();
                        break;
                    }
                }
            }

            else if (string.Compare(choice,"0") == 0)
            {
                Console.WriteLine("Exiteed...");
                break;
            }

            else
            {
                Console.WriteLine("Invalid argument");
            }

        }
    }
}
