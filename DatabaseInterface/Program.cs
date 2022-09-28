using DatabaseInterface;

var product = new Product();
bool valid;
string[] dataBases = new string[] { "list", "sql", "mongo" };
string userInput;
bool cont = true;

while (cont)
{
    Console.WriteLine("\nWhich type of database would you like? List, SQL, or Mongo?");

    do
    {
        userInput = Console.ReadLine().ToLower();
        if (dataBases.Contains(userInput))
        {
            valid = true;
            IDataAccess database = DataAccessFactory.GetDataAccessType(userInput);
            Console.WriteLine();
            database.LoadData();
            database.SaveData();
        }
        else
        {
            valid = false;
            Console.WriteLine("Invalid input");
        }
    } while (!valid);
    Console.WriteLine("\nWould you like to choose another database?");
    do
    {
        userInput = Console.ReadLine().ToLower();
        if (userInput == "yes" || userInput == "y")
        {
            cont = true;
            valid = true;
        }
        else if (userInput == "no" || userInput == "n")
        {
            cont = false;
            valid = true;
        }
        else
        {
            Console.WriteLine("Invalid input");
            valid = false;
        }
    } while (!valid);
}
