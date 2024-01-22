using System.Transactions;
using W5Day21_Task2;

Market market = new Market(100);

string? option;
do
{

    Console.WriteLine("\tMENU\t\n");
    Console.WriteLine("1. Add a product");
    Console.WriteLine("2. Sell a product");
    Console.WriteLine("3. View products");
    Console.WriteLine("4. Exit");

    Console.WriteLine("Select an option:");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            string priceStr;
            double price;
            string name;

            do
            {
                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));
            
            
            do
            {
                Console.WriteLine("Enter Price: ");
                priceStr = Console.ReadLine();
            } while (!double.TryParse(priceStr, out price) || price < 0);

            string countStr;
            int count;

            do
            {
                Console.WriteLine("Enter Count: ");
                countStr = Console.ReadLine();
            } while (!int.TryParse(countStr, out count) || count < 0);

            Product product = new Product(name, price, count);

            market.AddProduct(product);
            break;
        case "2":
            Console.WriteLine("Enter the name of the product to sell:");
            string sellName = Console.ReadLine();
            market.SellProduct(sellName);
            break;
        case "3":
            Console.WriteLine("\nProducts in the market:");
            try
            {
                market.ShowProducts();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"\nMessage: {ex.Message}\n");
            }
            break;
        case "4":
            Console.WriteLine("Program Finished!");
            break;
        default:
            Console.WriteLine("Selected operation is not true!");
            break;
    }


} while (option != "4");