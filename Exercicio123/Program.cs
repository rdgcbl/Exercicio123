using Exercicio123.Entities;
using Exercicio123.Entities.Enum;
using System.Globalization;


Console.WriteLine("Enter Client Data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime datanasc = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Client cli = new Client(name, email, datanasc);     //////////////// ok
Order ord = new Order(DateTime.Now, status, cli);   //////////////// n entendi

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string pName = Console.ReadLine();
    Console.Write("Product price: ");
    double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Product prod = new Product(pName, pPrice); //////////////// ok

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());

    OrderItem oItem = new OrderItem(quantity, pPrice, prod); //////////////// N entendi
    ord.AddItem(oItem); //////////////// n entendi

}

Console.WriteLine();
Console.WriteLine("ORDER SUMMARY");
Console.WriteLine(ord);