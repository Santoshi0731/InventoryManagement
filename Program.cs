using Newtonsoft.Json;
using System.Xml;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, World!");
            InventoryManager inventoryManager = new InventoryManager();
            while (true)
            {
                Console.WriteLine("Enter: \n1 for Adding\n2 for Printing inventory\n3 for Remove\n5 to save");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        inventoryManager.Add();
                        Console.WriteLine(JsonConvert.SerializeObject(inventoryManager.inventory, Formatting.Indented));
                        break;
                    case 2:
                        inventoryManager.PrintInventory();
                        break;
                    case 3:
                        inventoryManager.remove();
                        break;
                    case 4:
                        inventoryManager.Edit();
                        break;
                    case 5:
                        inventoryManager.Save();
                        break;
                    case 6:
                        inventoryManager.LoadFromFile();
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
            }
            //List<string> list = new List<string>()
            //{
            //    "sdgfjsd",
            //    "sjdfjsdf",
            //    "shgdfhgs",
            //};
            //foreach(string item in list)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
