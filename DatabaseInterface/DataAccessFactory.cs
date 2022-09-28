using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseInterface
{
    internal class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType)
            {
                case "list":
                    ListDataAccess listData = new ListDataAccess();
                    return listData;
                case "sql":
                    SQLDataAccess sqlData = new SQLDataAccess();
                    return sqlData;
                case "mongo":
                    MongoDataAccess mongoData = new MongoDataAccess();
                    return mongoData;
                default:
                    ListDataAccess listData2 = new ListDataAccess();
                    return listData2;
            }
        }
    }
}
