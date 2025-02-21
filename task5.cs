
// Task 5: Online Shopping Cart
// Task: Create a Product class with:
// Name, Price, and Quantity.
// A method TotalPrice() that returns Price * Quantity.
// In Main(), allow the user to add multiple products to a shopping cart and calculate the total cost.
// If more than 5 items are purchased, apply a 10% discount.

class Product 
{   
    public string name;
    public int price;
    public int quantity;

    public Product(string name, int price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set {quantity = value; }
    }

    public int TotalPrice(int price, int quantity)
    {
        if (quantity >= 5) {
            return (price * quantity) - (price * quantity)/10;
        }
        return price * quantity;
    }
}

class Program
{
    static void Main(string[] args)
    {
       Product bread = new Product("Bread",200,0);
       Product milk = new Product("Milk",600,0);
       Product icecream = new Product("IceCream",200,0);
       Product[] products = new Product[3] {bread, milk, icecream};

       for (int i = 0; i < products.Length; i++)
       {
            Console.WriteLine($"the product name is {products[i].name} and price is {products[i].price}");
       } 
       
       while (true)
       {    
            Console.WriteLine("Which product do you want? for exit 0");
            string? choiceproduct = Console.ReadLine();

            if (string.Compare(choiceproduct,"0") == 0){
                    break;
            }
            
            for (int i = 0; i < products.Length; i++)
            {
                if (string.Compare(products[i].name,choiceproduct) == 0) 
                {
                    Console.WriteLine("Do you want add or remove");
                    string? choice = Console.ReadLine();
                    Console.WriteLine("And how much");
                    if (int.TryParse(Console.ReadLine(),out int much) == false)
                    {
                        Console.WriteLine("Invalid input");
                        break;
                    } 
                    
                    if (string.Compare(choice,"add") == 0) 
                    {
                        products[i].quantity += much;
                        break;
                    } 

                    else if (string.Compare(choice,"remove") == 0)
                    {
                        if (products[i].quantity - much <= 0)
                        {
                            products[i].quantity = 0;
                            break;
                        }

                        else
                        {
                            products[i].quantity -= much;
                            break;
                        }
                    }
                }
                
            } 
       }
        for (int i = 0; i < products.Length; i++)
       {
            Console.WriteLine($"the product name is {products[i].name} and price is {products[i].TotalPrice(products[i].price,products[i].quantity)}");
       } 
    }   
}
