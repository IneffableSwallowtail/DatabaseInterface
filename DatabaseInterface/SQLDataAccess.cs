using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseInterface
{
    internal class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL.");
            var products = new List<Product>();
            return products;
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a SQL database.");
        }
    }
}
