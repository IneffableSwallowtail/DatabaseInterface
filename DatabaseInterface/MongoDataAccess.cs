using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseInterface
{
    internal class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo.");
            var products = new List<Product>();
            return products;
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a Mongo database.");
        }
    }
}
