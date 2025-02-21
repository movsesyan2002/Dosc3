// Task 4: Book Library
// Task: Create a Book class with:
// Title, Author, IsAvailable properties.
// A method BorrowBook() that sets IsAvailable = false.
// A method ReturnBook() that sets IsAvailable = true.
// In Main(), create 3 books, borrow one, and display availability status.
// Allow user interaction (choose which book to borrow/return).

class Book 
{
    public string title;
    public string author;
    public bool isavailable;

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
        this.isavailable = true;
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public bool IsAvailable
    {
        get { return isavailable; }
        set {isavailable = value; }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("Dog and cat","Hovhannes Tumanyan");
        Book book2 = new Book("Samvel","Raffi");
        Book book3 = new Book("Sherlock Holmes","Arthur Conan Doyle");
        Book[] books = new Book[] {book, book2, book3};
        Console.WriteLine("Enter your searched book");
        string? searched = Console.ReadLine();
        Console.WriteLine("Enter your decision borrow/return");
        string? decision = Console.ReadLine();  
        int flag = 0;

        for (int i = 0; i < books.Length; i++)
        {  
            if (string.Compare(searched, books[i].Title) == 0)
            {   
                flag = 1;
                if (string.Compare(decision,"borrow") == 0) 
                {
                    if (books[i].isavailable != false)
                    {
                        books[i].IsAvailable = false;
                    }
                    else
                    {
                        Console.WriteLine("The book borrowed");
                    }
                }

                else if (string.Compare(decision, "return") == 0)
                {
                    if (books[i].isavailable != true)
                    {
                        books[i].IsAvailable = true;
                    }
                    else
                    {
                        Console.WriteLine("The book is not returned");
                    }
                }
            }   
        }  

        
        if (flag == 0) 
        {
            Console.WriteLine("We don't have this book");
            return;
        } 

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"book{i+1} {books[i].title} available state is {books[i].isavailable}");
        }

    }   
}

