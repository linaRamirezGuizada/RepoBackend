// See https://aka.ms/new-console-template for more information
using JalaSoft.Dev.Level1.Practice1;

Console.WriteLine("Hello, World!");
Console.WriteLine("***********Italian restaurant Console App***********");

int client = 0;
string orderMenu = string.Empty;
int order = 0;
string payment = string.Empty;
string clientName = string.Empty;

Dictionary<int, List<DishesMenu>> orderList = new Dictionary<int, List<DishesMenu>>();
Queue<Dictionary<int, List<DishesMenu>>> ordersQueue = new Queue<Dictionary<int, List<DishesMenu>>>();

Console.WriteLine("Welcome I can take your order");
Console.WriteLine("what is name");
//clientName = Console.ReadLine();


while (order <= 4)
{
    while (orderMenu != "0")
    {
        Console.WriteLine("Choose of option please: ");
        Console.WriteLine("1. Spaghetti");
        Console.WriteLine("2. Lasagna");
        Console.WriteLine("3. Pizza");
        Console.WriteLine("4. Calzone");

        //orderMenu = Console.ReadLine();
        client = Convert.ToInt32(orderMenu);

        if (client != 0)
        {
            if (orderList.ContainsKey(order))
            {
                orderList[order].Add((DishesMenu)client);
            }
            else
            {
                orderList.Add(order, new List<DishesMenu> {(DishesMenu)client });
            }
        }

        ordersQueue.Enqueue(orderList);

    }
        
}

if (order <= 5)
{
    Console.WriteLine("You have reached your limit, preparing the top five orders");
}

Console.WriteLine("How to cancel");
Console.WriteLine("1. CreditCard");
Console.WriteLine("2. Money");
//payment = Console.ReadLine();



if (payment == "1")
{
    Console.WriteLine($"payment method: {PaymentFormat.CreditCard}");
}
else if (payment == "2")
{
    Console.WriteLine($"payment method: {PaymentFormat.Money}");
}