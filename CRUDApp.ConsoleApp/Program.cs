using CRUDApp.ConsoleApp.Logic;

namespace CRUDApp.ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to CRUDApp Created by @TayyabNazeerShaikh");
            IDataAccess dataAccess = new DataAccess();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Insert Data");
                Console.WriteLine("2. Update Data");
                Console.WriteLine("3. Delete Data");
                Console.WriteLine("4. Read Data");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter id to insert:");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter name to insert:");
                        string name = Console.ReadLine();
                        dataAccess.InsertData(id, name);    
                        break;

                    case "2":
                        Console.WriteLine("Enter ID to update:");
                        int idToUpdate = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new data[name]:");
                        string newData = Console.ReadLine();
                        dataAccess.UpdateData(idToUpdate, newData);
                        break;

                    case "3":
                        Console.WriteLine("Enter ID to delete:");
                        int idToDelete = int.Parse(Console.ReadLine());
                        dataAccess.DeleteData(idToDelete);
                        break;

                    case "4":
                        dataAccess.ReadData();
                        break;

                    case "5":
                        Console.WriteLine("Exiting program.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
    

    


