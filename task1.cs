// Task 1: Phone Book
// Task: Create a Contact class with:
// Name, PhoneNumber, and Email properties.
// A method DisplayInfo() to print contact details.
// A Main() method where the user can create 3 contacts and display them.
// Store contacts in an array and allow searching by name.class Contact 

class Contact 
{
    public string name;
    public string email;
    public string phone;

    public Contact(string name, string email, string phone) 
    {
        this.name = name;
        this.email = email;
        this.phone = phone;
    }

    public string Name 
    {
        get { return name; }
        set { name = value; }
    }

    public string Email 
    {
        get { return email; }
        set { email = value; }
    }

    public string Phone 
    {
        get { return phone; }
        set { phone = value; }
    }
    public void DisplayInfo() 
    {
        Console.WriteLine($"the name is {name}\nthe phone number is {phone}\nthe email is {email}\n");
    }
}
class Program 
{
    static void Main(string[] args) 
    {


        Contact[] persons = new Contact[3];
        for (int i = 0; i < persons.Length; i++)
        {   

            Console.WriteLine("Enter person name");
            string? pname = Console.ReadLine();
            Console.WriteLine("Enter person email");
            string? pemail = Console.ReadLine();
            Console.WriteLine("Enter person phone number");
            string? pnumber = Console.ReadLine();
            persons[i] = new Contact(pname, pemail,pnumber);

        }

        Console.WriteLine("Enter searching name");
        string? name = Console.ReadLine();
        int flag = 0;
        for (int i = 0; i < persons.Length; i++)
        {
            if (string.Compare(persons[i].name, name) == 0) 
            {
                flag = 1;
                persons[i].DisplayInfo();
            }
        }

        if (flag == 0) 
        {
            Console.WriteLine("no this contact");
        }
    }
}
