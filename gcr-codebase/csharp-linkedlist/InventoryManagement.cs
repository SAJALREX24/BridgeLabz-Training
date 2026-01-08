using System;

class ProductNode
{
    public int productCode;
    public string productName;
    public int stock;
    public double unitCost;
    public ProductNode link;
}

class InventoryManager
{
    ProductNode start;

    public void InsertProduct()
    {
        ProductNode node = new ProductNode();

        Console.Write("Product Code: ");
        node.productCode = int.Parse(Console.ReadLine());

        Console.Write("Product Name: ");
        node.productName = Console.ReadLine();

        Console.Write("Stock Quantity: ");
        node.stock = int.Parse(Console.ReadLine());

        Console.Write("Unit Cost: ");
        node.unitCost = double.Parse(Console.ReadLine());

        node.link = start;
        start = node;

        Console.WriteLine("Product Successfully Added");
    }

    public void DeleteProduct()
    {
        Console.Write("Enter Product Code: ");
        int code = int.Parse(Console.ReadLine());

        ProductNode current = start, previous = null;

        while (current != null && current.productCode != code)
        {
            previous = current;
            current = current.link;
        }

        if (current == null)
        {
            Console.WriteLine("Product Not Found");
            return;
        }

        if (previous == null)
            start = current.link;
        else
            previous.link = current.link;

        Console.WriteLine("Product Removed");
    }

    public void ModifyStock()
    {
        Console.Write("Product Code: ");
        int code = int.Parse(Console.ReadLine());

        Console.Write("Updated Stock: ");
        int newStock = int.Parse(Console.ReadLine());

        ProductNode temp = start;

        while (temp != null)
        {
            if (temp.productCode == code)
            {
                temp.stock = newStock;
                Console.WriteLine("Stock Updated");
                return;
            }
            temp = temp.link;
        }

        Console.WriteLine("Product Not Found");
    }

    public void FindProduct()
    {
        Console.Write("Enter Code or Name: ");
        string input = Console.ReadLine();

        ProductNode temp = start;

        while (temp != null)
        {
            if (temp.productCode.ToString() == input || temp.productName == input)
            {
                Console.WriteLine(temp.productName + " | Stock: " + temp.stock);
                return;
            }
            temp = temp.link;
        }

        Console.WriteLine("Product Not Found");
    }

    public void CalculateTotalWorth()
    {
        double totalWorth = 0;
        ProductNode temp = start;

        while (temp != null)
        {
            totalWorth += temp.unitCost * temp.stock;
            temp = temp.link;
        }

        Console.WriteLine("Total Inventory Worth: " + totalWorth);
    }

    public void ShowAll()
    {
        ProductNode temp = start;

        while (temp != null)
        {
            Console.WriteLine(
                temp.productCode + " " +
                temp.productName +
                " Qty:" + temp.stock +
                " Cost:" + temp.unitCost);

            temp = temp.link;
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryManager manager = new InventoryManager();
        int option;

        do
        {
            Console.WriteLine("\n--- Inventory Panel ---");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Update Stock");
            Console.WriteLine("4. Search Product");
            Console.WriteLine("5. Total Worth");
            Console.WriteLine("6. Display Products");
            Console.WriteLine("7. Exit");

            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: manager.InsertProduct(); break;
                case 2: manager.DeleteProduct(); break;
                case 3: manager.ModifyStock(); break;
                case 4: manager.FindProduct(); break;
                case 5: manager.CalculateTotalWorth(); break;
                case 6: manager.ShowAll(); break;
            }

        } while (option != 7);
    }
}
