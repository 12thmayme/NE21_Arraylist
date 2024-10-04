using System;
using System.Collections;
using System.Collections.Generic;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public DateTime CreatedDate { get; set; }
    public bool IsActive { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        // Khởi tạo mảng
        Item[] items = new Item[20]
        {
            new Item { Id = 1, Name = "Item 1", Price = 10.5, CreatedDate = DateTime.Now.AddDays(-1), IsActive = true },
            new Item { Id = 2, Name = "Item 2", Price = 21.0, CreatedDate = DateTime.Now.AddDays(-2), IsActive = false },
            new Item { Id = 3, Name = "Item 3", Price = 31.5, CreatedDate = DateTime.Now.AddDays(-3), IsActive = true },
            new Item { Id = 4, Name = "Item 4", Price = 42.0, CreatedDate = DateTime.Now.AddDays(-4), IsActive = false },
            new Item { Id = 5, Name = "Item 5", Price = 52.5, CreatedDate = DateTime.Now.AddDays(-5), IsActive = true },
            new Item { Id = 6, Name = "Item 6", Price = 63.0, CreatedDate = DateTime.Now.AddDays(-6), IsActive = false },
            new Item { Id = 7, Name = "Item 7", Price = 73.5, CreatedDate = DateTime.Now.AddDays(-7), IsActive = true },
            new Item { Id = 8, Name = "Item 8", Price = 84.0, CreatedDate = DateTime.Now.AddDays(-8), IsActive = false },
            new Item { Id = 9, Name = "Item 9", Price = 94.5, CreatedDate = DateTime.Now.AddDays(-9), IsActive = true },
            new Item { Id = 10, Name = "Item 10", Price = 105.0, CreatedDate = DateTime.Now.AddDays(-10), IsActive = false },
            new Item { Id = 11, Name = "Item 11", Price = 115.5, CreatedDate = DateTime.Now.AddDays(-11), IsActive = true },
            new Item { Id = 12, Name = "Item 12", Price = 126.0, CreatedDate = DateTime.Now.AddDays(-12), IsActive = false },
            new Item { Id = 13, Name = "Item 13", Price = 136.5, CreatedDate = DateTime.Now.AddDays(-13), IsActive = true },
            new Item { Id = 14, Name = "Item 14", Price = 147.0, CreatedDate = DateTime.Now.AddDays(-14), IsActive = false },
            new Item { Id = 15, Name = "Item 15", Price = 157.5, CreatedDate = DateTime.Now.AddDays(-15), IsActive = true },
            new Item { Id = 16, Name = "Item 16", Price = 168.0, CreatedDate = DateTime.Now.AddDays(-16), IsActive = false },
            new Item { Id = 17, Name = "Item 17", Price = 178.5, CreatedDate = DateTime.Now.AddDays(-17), IsActive = true },
            new Item { Id = 18, Name = "Item 18", Price = 189.0, CreatedDate = DateTime.Now.AddDays(-18), IsActive = false },
            new Item { Id = 19, Name = "Item 19", Price = 199.5, CreatedDate = DateTime.Now.AddDays(-19), IsActive = true },
            new Item { Id = 20, Name = "Item 20", Price = 210.0, CreatedDate = DateTime.Now.AddDays(-20), IsActive = false }
        };

        ArrayList arrayList = new ArrayList(items); 
        List<Item> itemList = new List<Item>(items); 

        itemList.RemoveAll(i => i.Price < 100);
        
        arrayList = new ArrayList(itemList);

        Console.WriteLine("Danh sách sau khi xóa (Price >= 100):");
        foreach (var item in itemList)
        {
            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}");
        }
    }
}
