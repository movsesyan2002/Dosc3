// Task 10: To-Do List Application
// Task: Create a TaskItem class with:
// Description, IsCompleted.
// Methods MarkComplete() and MarkIncomplete().
// Store multiple tasks in a list and allow users to add, remove, or mark tasks as complete.

class TaskItem
{

    private string description;
    private bool IsCompleted;

    public TaskItem(string Description)
    {
        this.description = Description;
        this.IsCompleted = false;
    }

    public string Description
    {
        get { return this.description; }
        set { this.description = value; }
    }

    public bool Iscompleted
    {
        get { return this.IsCompleted;}
        set { this.IsCompleted = value;}
    }

    public void MarkComplete()
    {
        if (this.Iscompleted == true)
        {
            Console.WriteLine("The task is already marked as completed");
        }

        else 
        {
            this.Iscompleted = true;
        }
    }

    public void MarkIncomplete()
    {

        if (this.Iscompleted == false)
        {
            Console.WriteLine("The task is already marked as incompleted");
        }

        else 
        {
            this.Iscompleted = false;
        }

    }

    public void Display()
    {
        Console.WriteLine($"\nTask description {this.Description}");

        if (this.Iscompleted == true)
        {
            Console.WriteLine("Task status: iscompleted");
        }

        else
        {
            Console.WriteLine("Task status is Incompleted");
        } 
    }
}

class TaskManager
{
    List <TaskItem> _managerTask;

    int _managerTasksCount;

    public TaskManager()
    {
        this._managerTask = new List <TaskItem>();
        this._managerTasksCount = 0;
    }

    public void AddTask()
    {
        Console.WriteLine("Enter a description");
        string? desc = Console.ReadLine();
        this._managerTask.Add (new TaskItem(desc));
        this._managerTasksCount++;
        Console.WriteLine("The task is successfully added");

    }

    public void RemoveTask()
    {
        Console.WriteLine("Which task do you want remove?");
        string? desc = Console.ReadLine();

        for (int i = 0; i < this._managerTasksCount; i++)
        {
            if (string.Compare(this._managerTask[i].Description, desc, true) == 0)
            {
                this._managerTask.Remove(this._managerTask[i]);
                --this._managerTasksCount;
                break;
            }

            if (i == this._managerTasksCount)
            {
                Console.WriteLine("There is no such task");
            }
        }
    }

    public void MarkcompleteInList()
    {
        Console.WriteLine("Which task do you want");
        string? desc = Console.ReadLine();

        for (int i = 0; i < this._managerTasksCount; i++)
        {
            if (string.Compare(desc, this._managerTask[i].Description, true) == 0)
            {
                this._managerTask[i].MarkComplete();
                break;
            }

            if (i == this._managerTasksCount)
            {
                Console.WriteLine("There is no such task");
            }
        }
    }

    public void MarkIncompleteInList()
    {
        Console.WriteLine("Which task do you want");
        string? desc = Console.ReadLine();

        for (int i = 0; i < this._managerTasksCount; i++)
        {
            if (string.Compare(desc, this._managerTask[i].Description, true) == 0)
            {
                this._managerTask[i].MarkIncomplete();
                break;
            }

            if (i == this._managerTasksCount)
            {
                Console.WriteLine("There is no such task");
            }
        }
    }

    public void Display()
    {
        for (int i = 0; i < this._managerTasksCount; i++)
        {
            Console.WriteLine($"The task description is {this._managerTask[i].Description}");
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        TaskManager manager = new TaskManager();
        string? answ;
        while (true) {
            Console.WriteLine();
            Console.WriteLine("Enter '+' to add a task");
            Console.WriteLine("Enter '-' to add a task");
            Console.WriteLine("Enter 'C' to mark a task as completed");
            Console.WriteLine("Enter 'I' to mark a task as incomleted");
            Console.WriteLine("Enter 'L' to show all Tasks");
            Console.WriteLine("Enter 'X' to exit");
            answ = Console.ReadLine();
            if (answ == "x" || answ == "X") {
                break;
            } else if (answ == "+") {
                manager.AddTask();
            } else if (answ == "-") {
                manager.RemoveTask();
            } else if (answ == "c" || answ == "C") {
                manager.MarkcompleteInList();
            } else if (answ == "i" || answ == "I") {
                manager.MarkIncompleteInList();
            } else if (answ == "l" || answ == "L") {
                manager.Display();
            } else {
                Console.WriteLine("invalid command, try again");
            }
        }
        Console.WriteLine("GoodBye!");
    
    }
}
