// Task 6: Employee Payroll System
// Task: Create an Employee class with:
// Name, Position, SalaryPerHour, and HoursWorked.
// A method CalculateSalary() that returns SalaryPerHour * HoursWorked.
// In Main(), create 3 employees, calculate their salaries, and display them.
// If an employee works over 40 hours, pay overtime (1.5x rate).

class Employee
{
    public string Name; 
    public string Position; 
    public int SalaryPerHour; 
    public int HoursWorked;

    public Employee(string name, string position,int salaryPerHour,int hoursWorked)
    {
        this.Name = name;
        this.Position = position;
        this.SalaryPerHour = salaryPerHour;
        this.HoursWorked = hoursWorked;
    }
    public double CalculateSalary(int SalaryPerHour,int HoursWorked)
    {
        if (HoursWorked >= 40) 
        {
            return SalaryPerHour * HoursWorked * 1.5;
        }
        return SalaryPerHour * HoursWorked;
    }

}

class Program
{
    static void Main(string[] args) 
    {
        Employee employee = new Employee("John","saller",100,45);
        Employee employee2 = new Employee("Michael","manager",150,50);
        Employee employee3 = new Employee("Ann","chef",100,30);
        Employee[] employers = new Employee[3] {employee,employee2,employee3};

        foreach (Employee item in employers)
        {
            Console.WriteLine($"{item.Name} is a {item.Position} and salary is {item.CalculateSalary(item.SalaryPerHour,item.HoursWorked)}");
        }

    }
}
