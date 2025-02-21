// Task 8: School System
// Task: Create a School Management System with:
// Student class (Name, Age, Grade).
// Teacher class (Name, Subject, YearsOfExperience).
// School class that stores students & teachers in an array.
// Show students with the highest grade and teachers with less than 2 years experience.


class Student
{
    private string name;
    private int age;
    private int grade;

    public Student (string name, int age, int grade)
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
        get {return grade; }
        set {grade = value; }
    }
}

class Teacher
{
    private string name;
    private string subject;
    private int yearsofexperience;

    public Teacher (string name,string subject,int yearsofexperience)
    {
        this.name = name;
        this.subject = subject;
        this.yearsofexperience = yearsofexperience;
    }

    public string Name
    {
        get {return name;}
        set {name = value;}
    }

    public string Subject
    {
        get {return subject;}
        set {subject = value;}
    }

    public int Yearsofexperience
    {
        get {return yearsofexperience;}
        set {yearsofexperience = value;}
    }

}

class School
{
    public Student[] students = new Student[3];

    public Teacher[] teachers = new Teacher[3];


}


class Program
{
    static void Main (string[] args)
    {
        School school = new School();
        school.students[0] = new Student("John",19,99);
        school.students[1] = new Student("Mike",19,89);
        school.students[2] = new Student("Ann",19,99);

        school.teachers[0] = new Teacher("Bob","lecturer",10);
        school.teachers[1] = new Teacher("Sindy","lecturer",2);
        school.teachers[2] = new Teacher("Jessica","lecturer",2);

        int max = 0;
        for (int i = 0; i < school.students.Length; i++)
        {
            if (school.students[i].Grade > max)
            {
                max = school.students[i].Grade;
            }
        }

        for (int i = 0; i < school.students.Length; i++)
        {
            if (school.students[i].Grade == max)
            {
                Console.WriteLine($"The best students are {school.students[i].Name} and grade is {school.students[i].Grade}");
            }
        }

        Console.WriteLine();
        for (int i = 0; i < school.students.Length; i++)
        {
            if (school.teachers[i].Yearsofexperience <= 2)
            {
                Console.WriteLine($"The best students are {school.teachers[i].Name} and subject is {school.teachers[i].Subject}");
            }
        }

    }
}