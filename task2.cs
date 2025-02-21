// // Task 2: Student Management
// // Task: Create a Student class with:
// // Name, Age, and Grade properties.
// // A DisplayDetails() method.
// // In Main(), create 5 students, store them in an array, and display their details.

class Student 
{
    public string name;
    public int age;
    public int grade;

    public Student(string name, int age, int grade) 
    {
        this.name = name;
        this.age = age;
        this.grade = grade;
    }

    public string Name 
    {
        get { return name; }
        set { name = value; }
    }

    public int Age 
    {
        get { return age; }
        set { age = value; }
    }

    public int Grade 
    {
        get { return grade; }
        set { grade = value; }
    }
    public void DisplayInfo() 
    {
        Console.WriteLine($"Student name is {name}\nStudent age is {age}\nStudent grade is {grade}\n");
    }
}
class Program 
{
    static void Main(string[] args) 
    {

        Student[] student = new Student[5];
        for (int i = 0; i < student.Length; i++)
        {   

            Console.WriteLine("Enter student name");
            string? sname = Console.ReadLine();
            Console.WriteLine("Enter student age");
            int sage = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student grade");
            int sgrade = int.Parse(Console.ReadLine());
            student[i] = new Student(sname, sage, sgrade);
        }
        Console.WriteLine("Enter searching name");
        string? name = Console.ReadLine();

        for (int i = 0; i < student.Length; i++)
        {
                student[i].DisplayInfo();

        }
    }
}

