using System;

interface IInventoryManager
{
    void AddStock(string productName, int quantity);
    void SellStock(string productName, int quantity);
}

class GroceryStock : IInventoryManager
{
    private int stock = 100;

    public void AddStock(string productName, int quantity)
    {
        if (string.IsNullOrEmpty(productName))
            throw new Exception("Invalid grocery product name.");

        stock += quantity;
        Console.WriteLine($"{quantity} grocery items added. Total Stock: {stock}");
    }

    public void SellStock(string productName, int quantity)
    {
        if (string.IsNullOrEmpty(productName))
            throw new Exception("Invalid grocery product name.");

        if (quantity > stock)
            throw new Exception("Grocery stock shortage!");

        stock -= quantity;
        Console.WriteLine($"{quantity} grocery items sold. Remaining Stock: {stock}");
    }
}

class ElectronicStock : IInventoryManager
{
    private int stock = 50;

    public void AddStock(string productName, int quantity)
    {
        if (string.IsNullOrEmpty(productName))
            throw new Exception("Invalid electronic product name.");

        stock += quantity;
        Console.WriteLine($"{quantity} electronic items added. Total Stock: {stock}");
    }

    public void SellStock(string productName, int quantity)
    {
        if (string.IsNullOrEmpty(productName))
            throw new Exception("Invalid electronic product name.");

        if (quantity > stock)
            throw new Exception("Electronic stock shortage!");

        stock -= quantity;
        Console.WriteLine($"{quantity} electronic items sold. Remaining Stock: {stock}");
    }
}